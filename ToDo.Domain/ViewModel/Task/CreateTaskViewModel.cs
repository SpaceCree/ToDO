using ClassLibrary1.Enum;

namespace ClassLibrary1.ViewModel.Task;

public class CreateTaskViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
}