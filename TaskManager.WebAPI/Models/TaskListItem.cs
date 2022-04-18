using TaskManager.DB.Lib;
using TaskManager.DB.Models;
using TaskModel = TaskManager.DB.Models.Task;

namespace TaskManager.WebAPI.Models;

public class TaskListItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime? Deadline { get; set; }
    public string Status { get; set; }

    public TaskListItem() {}

    public TaskListItem(TaskModel task, StatusTask status)
    {
        Init(task, status);
    }

    public void Init(TaskModel task, StatusTask status)
    {
        Id = task.Id;
        Title = task.Title;
        Deadline = task.Deadline;
        Status = status.Status;
    }

    public static async Task<List<TaskListItem>> GetPreviewListAsync()
    {
        var tasks = await new CrudTaskDb().GetAllTasksAsync();
        var statuses = await new CrudStatusTaskDb().GetAllStatusTasksAsync();

        return (from task in tasks 
                let status = statuses.First(s => s.Id == task.StatusId) 
                select new TaskListItem(task, status))
            .ToList();
    }
}