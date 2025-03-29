namespace HTTPGRUPO5.Models;

public class TaskItem
{
    public int Id { get; set; }  
    public string Title { get; set; } = string.Empty;  
    public bool Status { get; set; } = false;
}