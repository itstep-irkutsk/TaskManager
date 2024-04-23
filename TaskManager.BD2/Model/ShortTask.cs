using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.DB2.Models;

public record ShortTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime? Deadline { get; set; }
    public string Status { get; set; }
}