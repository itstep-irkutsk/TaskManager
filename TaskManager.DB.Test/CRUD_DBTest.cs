using System;
using System.Collections.Generic;
using System.IO;
using TaskManager.DB.Lib;
using TaskManager.DB.Models;
using Xunit;

namespace TaskManager.DB.Test;

public class CRUD_DBTest
{
    [Fact]
    public void GetAllStagesAsync_Test()
    {
        IEnumerable<Stage> expectedStages = new List<Stage>
        {
            new()
            {
                Id = 6, 
                Description = "description 1", 
                DateOfCreation = new DateTime(2022, 4, 11, 15, 57, 18),
                TaskId = 2
            },
            new()
            {
                Id = 7, 
                Description = "description 2", 
                DateOfCreation = new DateTime(2022, 1, 11, 15, 57, 47),
                TaskId = 2
            }
        };

        var conn = GetJsonFromFile();
        var db = new CRUD_DB(conn);
        var actualStages = db.GetAllStagesAsync().Result;
        
        Assert.Equal(expectedStages, actualStages);
    }

    private string GetJsonFromFile()
    {
        return File.ReadAllText(@"config_db.json");
    }
}