using TaskManager.DB2.Crud;
using TaskManager.DB2.Models;
using TaskModel = TaskManager.DB.Models.Task;

namespace TaskManager.WebAPI.Models;

public class TaskListItem
{

    public TaskListItem() {}
    

    public static async Task<IEnumerable<ShortTask>> GetPreviewListAsync()
    {
        Crud task = new Crud();
        var tasks = await task.GetAllShortTasksAsync();
        return tasks;
    }
}