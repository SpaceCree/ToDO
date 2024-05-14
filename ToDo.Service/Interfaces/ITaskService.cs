using ClassLibrary1.Entity;
using ClassLibrary1.Response;
using ClassLibrary1.ViewModel.Task;

namespace ToDoService.Interfaces;

public interface ITaskService
{
    //add 
    Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model);

    Task<IBaseResponse<IEnumerable<TaskViewModel>>> GetTasks();
}