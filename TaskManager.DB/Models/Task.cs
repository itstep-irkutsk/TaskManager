namespace TaskManager.DB.Models;

public record Task
{
    public int Id { get; init; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateOfCreation { get; init; }
    public DateTime? DateOfStart { get; set; }
    public DateTime? DateOfEnd { get; set; }
    public DateTime? Deadline { get; set; }
    public int StatusId { get; set; }
}