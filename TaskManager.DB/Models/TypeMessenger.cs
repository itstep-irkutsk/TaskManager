namespace TaskManager.DB.Models;

public record TypeMessenger
{
    public int Id { get; init; }
    public string Type { get; set; }
}