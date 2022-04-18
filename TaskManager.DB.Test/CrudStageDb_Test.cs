using System;
using System.Collections.Generic;
using TaskManager.DB.Lib;
using TaskManager.DB.Models;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace TaskManager.DB.Test;

public class CrudStageDbTest
{
    [Fact]
    public async Task GetAllStagesAsync_Test()
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
        
        var db = new CrudStageDb();
        var actualStages = await db.GetAllStagesAsync();
        
        Assert.Equal(expectedStages, actualStages);
    }
}