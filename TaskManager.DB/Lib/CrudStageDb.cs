using Dapper;
using TaskManager.DB.Models;

namespace TaskManager.DB.Lib;

public class CrudStageDb : DbConnect
{
    public CrudStageDb() : base() { }

    public async Task<IEnumerable<Stage>> GetAllStagesAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, description, date_of_creation, task_id FROM tbl_stages";
        var stages = await _db.QueryAsync<Stage>(sql);
        
        await _db.CloseAsync();

        return stages;
    }
}