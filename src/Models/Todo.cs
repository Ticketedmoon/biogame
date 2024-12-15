namespace src.Models;

using System.Text.Json.Serialization;

public class Todo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("is_complete")]
    public bool IsComplete { get; set; }

    public Todo(int Id, string Name, bool IsComplete)
    {
        this.Id = Id;
        this.Name = Name;
        this.IsComplete = IsComplete;
    }
}