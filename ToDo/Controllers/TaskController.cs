using System.Diagnostics;
using System.Threading.Tasks.Sources;
using ClassLibrary1.ViewModel.Task;
using Microsoft.AspNetCore.Mvc;
using ToDoService.Interfaces;

namespace ToDo.Controllers;

public class TaskController : Controller
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateTaskViewModel model)
    {
        var response = await _taskService.Create(model);
        return Ok();
    }


    public async Task<IActionResult> TaskHandler()
    {
        var response = await _taskService.GetTasks();
        
        return Json(new { data = response.Data });
    }
}