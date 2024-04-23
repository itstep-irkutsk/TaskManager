using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.DB2.Models;

public record LongTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Date_of_creation { get; set; }
    public string Date_of_start { get; set; }
    public string Date_of_end { get; set; }
    public DateTime? Deadline { get; set; }
    public string Status { get; set; }
    public string Login { get; set; }
    public string Description { get; set; }
}