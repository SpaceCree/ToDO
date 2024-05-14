using ClassLibrary1.Enum;
namespace ClassLibrary1.Entity;
public class TaskEntity
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public Priority Priority { get; set; }

    public Status Status { get; set; }
    
    public DateTime Created { get; set; }
    
    public bool IsDone { get; set; }
}