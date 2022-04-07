namespace TaskManager.DB.Models;

public record UserMessenger
{
    public int Id { get; init; }
    public int UserId { get; init; }
    public int TypeId { get; init; }
    public string Link { get; set; }
}