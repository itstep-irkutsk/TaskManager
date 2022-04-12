using Dapper;
using MySql.Data.MySqlClient;
using TaskManager.DB.DB_Config;
using TaskManager.DB.Models;

namespace TaskManager.DB.Lib;

public class CrudStatusTaskDb
{
    private readonly MySqlConnection _db;

    public CrudStatusTaskDb(string connectionConfig)
    {
        var configDb = DataBaseConfig.CreateFromJson(connectionConfig);
        _db = new MySqlConnection(configDb.ToString());
        
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
    }

    public async Task<IEnumerable<StatusTask>> GetAllStatusTasksAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, status FROM tbl_status_task;";
        var statuses = await _db.QueryAsync<StatusTask>(sql);
        
        await _db.CloseAsync();

        return statuses;
    }
}