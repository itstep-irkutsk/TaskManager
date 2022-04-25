using MySql.Data.MySqlClient;

namespace TaskManager.DB2.Crud;

public abstract class DbConnect
{
    protected readonly MySqlConnection _db;
    
    protected DbConnect()
    {
        var configDb = DataBaseConfig.CreateFromJson();
        _db = new MySqlConnection(configDb.ToString());
        
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
    }
}