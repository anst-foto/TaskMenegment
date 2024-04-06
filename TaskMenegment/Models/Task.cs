namespace TaskMenegment.Models;

public enum TaskStatus
{
    Created, Done, InWork, Delayed, Canceled
}

public class Task
{
    public required string Title { get; set; }
    public required DateTime DeadLine { get; set; }
    public TaskStatus Status { get; set; } = TaskStatus.Created;
    public required Person Executor { get; set; }
    public string? Description { get; set; }
}