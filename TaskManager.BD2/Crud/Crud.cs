using Dapper;
using TaskManager.DB2.Models;

namespace TaskManager.DB2.Crud;

public class Crud : DbConnect
{
    public Crud() : base() { }

    public async Task<IEnumerable<LongTask>> GetAllLongTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, title, content, date_of_creation, date_of_start, date_of_end, deadline, statys, login, description FROM tbl_tasks JOIN tbl_status_task JOIN tbl_task_users Join tbl_users JOIN tbl_stages ON tbl_tasks.status_id = tbl_status_task.status ON tbl_task_users.task_id = tbl.tasks.id On tbl_task_users.user_id = tbl_users.id ON tbl_stages.task_id = tbl_tasks.id;";
        var tasks = await _db.QueryAsync<LongTask>(sql);
        
        await _db.CloseAsync();

        return tasks;
    }
    public async Task<IEnumerable<ShortTask>> GetAllShortTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, title, deadline, statys FROM tbl_tasks JOIN tbl_status_task ON tbl_tasks.status_id = tbl_status_task.status;";
        var tasks = await _db.QueryAsync<ShortTask>(sql);
        
        await _db.CloseAsync();

        return tasks;
    }
}