namespace AiDemo.Pages;

using System.Text;
using System.Text.Json;
using AiDemo.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;

public class IndexModel : PageModel
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    [BindProperty]
    public string Prompt { get; set; } = string.Empty;

    //800x500 --> size
    //?text=Image+Preview --> text
    public string GeneratedImageUrl { get; set; } = "https://placehold.co/800x500?text=Image+Preview";

    //Constructor to inject IHttpClientFactory and IConfiguration
    //
        public IndexModel(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task OnPostGenerateImage()
    {
        var endpoint = _configuration["Foundry:Endpoint"];
        var apiKey = _configuration["Foundry:ApiKey"];
        var model = _configuration["Foundry:ImageModel"];

        if (string.IsNullOrWhiteSpace(endpoint) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(model))
        {
            GeneratedImageUrl = "https://placehold.co/800x500?text=Missing+secrets";
            return;
        }

        var client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("api-key", apiKey);

        var request = new ImageGenerationRequest
        {
            Prompt = Prompt,
            Width = 1024,
            Height = 768,
            Model = model
        };

        var json = JsonSerializer.Serialize(request);
        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        //await--> this class is async, and returns a Task
        //so we can use await to wait for the response
        var response = await client.PostAsync(
            $"{endpoint.TrimEnd('/')}/mai/v1/images/generations",
            content);

        if (response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync();

            using JsonDocument json2 = JsonDocument.Parse(body);
            string? base64Image = json2.RootElement
                .GetProperty("data")[0]
                .GetProperty("b64_json")
                .GetString();

            if (!string.IsNullOrWhiteSpace(base64Image))
            {
                byte[] imageBytes = Convert.FromBase64String(base64Image);
                GeneratedImageUrl = $"data:image/png;base64,{Convert.ToBase64String(imageBytes)}";
            }
            else
            {
                GeneratedImageUrl = "https://placehold.co/800x500?text=Image+Result+Missing";
            }
        }
        else
        {
            GeneratedImageUrl = "https://placehold.co/800x500?text=Image+Request+Failed";
        }
    }

    [BindProperty]
public string TextPrompt { get; set; } = string.Empty;

public string TextAnswer { get; set; } = string.Empty;

public async Task OnPostGenerateText()
{
    var endpoint = _configuration["Foundry:Endpoint"];
    var apiKey = _configuration["Foundry:ApiKey"];
    var model = _configuration["Foundry:TextModel"];

    if (string.IsNullOrWhiteSpace(endpoint) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(model))
    {
        TextAnswer = "Missing GPT-5 secret configuration.";
        return;
    }

    var client = _httpClientFactory.CreateClient();
    client.DefaultRequestHeaders.Add("api-key", apiKey);

    var request = new TextGenerationRequest
    {
        Model = model,
        Input = TextPrompt,
        MaxOutputTokens = 250
    };

    var requestJson = JsonSerializer.Serialize(request);
    using var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

    var textEndpoint = endpoint.TrimEnd('/');
    if (!textEndpoint.EndsWith("/responses", StringComparison.OrdinalIgnoreCase))
    {
        textEndpoint = textEndpoint.Contains("/openai", StringComparison.OrdinalIgnoreCase)
            ? $"{textEndpoint}/responses"
            : $"{textEndpoint}/openai/v1/responses";
    }

    var response = await client.PostAsync($"{textEndpoint}?api-version=v1", content);

    if (response.IsSuccessStatusCode)
    {
        var body = await response.Content.ReadAsStringAsync();
        using JsonDocument responseJson = JsonDocument.Parse(body);

        string? answer = null;
        if (responseJson.RootElement.TryGetProperty("output", out var output))
        {
            foreach (var item in output.EnumerateArray())
            {
                if (!item.TryGetProperty("content", out var contentArray))
                {
                    continue;
                }

                foreach (var contentItem in contentArray.EnumerateArray())
                {
                    if (contentItem.TryGetProperty("type", out var type) &&
                        type.GetString() == "output_text" &&
                        contentItem.TryGetProperty("text", out var textElement))
                    {
                        answer = textElement.GetString();
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(answer))
                {
                    break;
                }
            }
        }

        TextAnswer = answer ?? "No answer was returned.";
    }
    else
    {
        var errorBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(errorBody);
        TextAnswer = "The GPT-5 request failed.";
    }
}
}