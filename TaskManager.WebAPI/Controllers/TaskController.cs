using Microsoft.AspNetCore.Mvc;

namespace TaskManager.WebAPI.Controllers;

[ApiController]
[Route("api/v0/task")]
public class TaskController : ControllerBase
{
    [HttpGet("{id:int}")]
    public JsonResult GetTask(int id)
    {
        return new JsonResult(new {result = true, _id = id});
    }
    
    [HttpPost("create")]
    public JsonResult CreateTask()
    {
        return new JsonResult(new {result = true});
    }
    
    [HttpPut("update/{id:int}")]
    public JsonResult UpdateTask(int id)
    {
        return new JsonResult(new {result = true, _id = id});
    }
    
    [HttpDelete("delete/{id:int}")]
    public JsonResult DeleteTask(int id)
    {
        return new JsonResult(new {result = true, _id = id});
    }
}