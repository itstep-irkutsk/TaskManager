namespace TaskManager.DB.Models;

public record TaskUser
{
    public int Id { get; init; }
    public int TaskId { get; set; }
    public int UserId { get; set; }
}