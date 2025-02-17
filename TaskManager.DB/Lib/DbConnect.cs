﻿using MySql.Data.MySqlClient;
using TaskManager.DB.DB_Config;

namespace TaskManager.DB.Lib;

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