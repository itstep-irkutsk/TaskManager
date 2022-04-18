using Dapper;

namespace TaskManager.DB.Lib;

public class CrudTaskDb : DbConnect
{
    public CrudTaskDb() : base() { }

    public async Task<IEnumerable<Models.Task>> GetAllTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, title, content, date_of_creation, date_of_start, date_of_end, deadline, status_id FROM tbl_tasks;";
        var tasks = await _db.QueryAsync<Models.Task>(sql);
        
        await _db.CloseAsync();

        return tasks;
    }
}