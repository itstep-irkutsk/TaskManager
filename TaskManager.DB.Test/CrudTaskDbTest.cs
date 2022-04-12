using System;
using System.Collections.Generic;
using System.IO;
using TaskManager.DB.Lib;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace TaskManager.DB.Test;

public class CrudTaskDbTest
{
    [Fact]
    public async Task GetAllTasksAsync_Test()
    {
        IEnumerable<Models.Task> expectedTasks = new List<Models.Task>
        { 
            new()
            {
                Id = 2,
                Title = "Task 1",
                Content = "content 1",
                DateOfCreation = new DateTime(2022, 1, 1, 16, 00, 33),
                DateOfStart = new DateTime(2022, 4, 11, 16, 00, 46),
                DateOfEnd = null,
                Deadline = null,
                StatusId = 1
            }
        };
        
        var conn = GetJsonFromFile();
        var db = new CrudTaskDb(conn);
        var actualTasks = await db.GetAllTasksAsync();
        
        Assert.Equal(expectedTasks, actualTasks);
    }
    
    private string GetJsonFromFile()
    {
        return File.ReadAllText(@"config_db.json");
    }
}