using System;
using System.Collections.Generic;
using System.IO;
using TaskManager.DB.Lib;
using TaskManager.DB.Models;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace TaskManager.DB.Test;

public class CrudStatusTaskDbTest
{
    [Fact]
    public async Task GetAllStatusTaskAsync_Test()
    {
        IEnumerable<StatusTask> expectedStages = new List<StatusTask>
        {
            new()
            {
                Id = 1,
                Status = "created"
            }
        };

        var conn = GetJsonFromFile();
        var db = new CrudStatusTaskDb(conn);
        var actualStages = await db.GetAllStatusTasksAsync();
        
        Assert.Equal(expectedStages, actualStages);
    }

    private string GetJsonFromFile()
    {
        return File.ReadAllText(@"config_db.json");
    }
}