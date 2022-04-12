using Dapper;
using MySql.Data.MySqlClient;
using TaskManager.DB.DB_Config;
using TaskManager.DB.Models;

namespace TaskManager.DB.Lib;

public class CrudStageDb
{
    private readonly MySqlConnection _db;

    public CrudStageDb(string connectionConfig)
    {
        var configDb = DataBaseConfig.CreateFromJson(connectionConfig);
        _db = new MySqlConnection(configDb.ToString());
        
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
    }

    public async Task<IEnumerable<Stage>> GetAllStagesAsync()
    {
        await _db.OpenAsync();

        var sql = "SELECT id, description, date_of_creation, task_id FROM tbl_stages";
        var stages = await _db.QueryAsync<Stage>(sql);
        
        await _db.CloseAsync();

        return stages;
    }
}