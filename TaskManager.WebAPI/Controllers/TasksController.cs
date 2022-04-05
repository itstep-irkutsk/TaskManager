using Microsoft.AspNetCore.Mvc;

namespace TaskManager.WebAPI.Controllers;

[ApiController]
[Route("api/v0/tasks")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public JsonResult GetAllTasks()
    {
        return new JsonResult(new {result = true});
    }
}