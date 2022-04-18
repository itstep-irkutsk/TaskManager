using Microsoft.AspNetCore.Mvc;
using TaskManager.WebAPI.Models;

namespace TaskManager.WebAPI.Controllers;

[ApiController]
[Route("api/v0/tasks")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public async Task<JsonResult> GetAllTasks()
    {
        return new JsonResult(await TaskListItem.GetPreviewListAsync());
    }
}