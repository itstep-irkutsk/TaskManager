using Dapper;
using TaskManager.DB.Models;

namespace TaskManager.DB.Lib;

public class CrudStatusTaskDb : DbConnect
{
    public CrudStatusTaskDb() : base() { }

    public async Task<IEnumerable<StatusTask>> GetAllStatusTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, status FROM tbl_status_task;";
        var statuses = await _db.QueryAsync<StatusTask>(sql);
        
        await _db.CloseAsync();

        return statuses;
    }
}