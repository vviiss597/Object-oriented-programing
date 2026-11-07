namespace AiDemo.Models;

using System.Text.Json.Serialization;

public class TextGenerationRequest
{
    [JsonPropertyName("model")]
    public string Model { get; set; } = string.Empty;

    [JsonPropertyName("input")]
    public string Input { get; set; } = string.Empty;

    [JsonPropertyName("max_output_tokens")]
    public int MaxOutputTokens { get; set; } = 300;
}