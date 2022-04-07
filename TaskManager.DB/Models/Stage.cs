namespace TaskManager.DB.Models;

public record Stage
{
    public int Id { get; init; }
    public string Description { get; set; }
    public DateTime DateOfCreation { get; init; }
    public int TaskId { get; init; }
}