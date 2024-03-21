using System.ComponentModel.DataAnnotations;

namespace MvcTasks.Models;

public class Task
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    [DataType(DataType.Date)]
    public DateTime Deadline { get; set; }
    public string? Status { get; set; }

    public bool timerEnded { get; set; } = false;
}