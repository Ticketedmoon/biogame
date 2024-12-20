namespace src.Models;

using System.Text.Json.Serialization;

public class Todo(int Id, string Name, bool IsComplete)
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = Id;
    [JsonPropertyName("name")]
    public string? Name { get; set; } = Name;
    [JsonPropertyName("is_complete")]
    public bool IsComplete { get; set; } = IsComplete;
}