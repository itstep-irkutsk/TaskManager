namespace TaskManager.DB.Models;

public record StatusTask
{
    public int Id { get; init; }
    public string Status { get; set; }
}