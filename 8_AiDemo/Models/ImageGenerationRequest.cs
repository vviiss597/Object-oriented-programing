namespace AiDemo.Models;

using System.Text.Json.Serialization;

public class ImageGenerationRequest
{
    //[JsonPropertyName("prompt")]
    // --> means that the property will be serialized to JSON with the name "prompt"
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;
    //without get and set --> fields
    //get and set --> properties

    [JsonPropertyName("width")]
    public int Width { get; set; } = 1024;
    
    [JsonPropertyName("height")]
    public int Height { get; set; } = 768;

    [JsonPropertyName("model")]
    public string Model { get; set; } = string.Empty;
}