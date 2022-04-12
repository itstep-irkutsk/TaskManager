using Dapper;
using MySql.Data.MySqlClient;
using TaskManager.DB.DB_Config;
using TaskManager.DB.Models;

namespace TaskManager.DB.Lib;

public class CrudTaskDb
{
    private readonly MySqlConnection _db;

    public CrudTaskDb(string connectionConfig)
    {
        var configDb = DataBaseConfig.CreateFromJson(connectionConfig);
        _db = new MySqlConnection(configDb.ToString());
        
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
    }

    public async Task<IEnumerable<Models.Task>> GetAllTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, title, content, date_of_creation, date_of_start, date_of_end, deadline, status_id FROM tbl_tasks;";
        var tasks = await _db.QueryAsync<Models.Task>(sql);
        
        await _db.CloseAsync();

        return tasks;
    }
}