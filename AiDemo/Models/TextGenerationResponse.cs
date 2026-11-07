namespace AiDemo.Models;

public class TextGenerationResponse
{
    public string? Answer { get; set; }
    public string? Model { get; set; }
    public string? ErrorMessage { get; set; }
}