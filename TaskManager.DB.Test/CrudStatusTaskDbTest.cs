using System.Collections.Generic;
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
        
        var db = new CrudStatusTaskDb();
        var actualStages = await db.GetAllStatusTasksAsync();
        
        Assert.Equal(expectedStages, actualStages);
    }
}