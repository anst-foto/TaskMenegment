using Task = TaskMenegment.Models.Task;
using TaskStatus = TaskMenegment.Models.TaskStatus;

namespace TaskMenegment;

public static class Cli
{
    private static void PrintTaskColor(Task task, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine("=== === === === ===");
        Console.WriteLine($"Title: {task.Title}");
        Console.WriteLine($"Deadline: {task.DeadLine:g}");
        Console.WriteLine(task.Description is null ? "Description: no description" : $"Description: {task.Description}");
        Console.WriteLine($"Status: {task.Status}");
        Console.WriteLine($"Executor: {task.Executor.FullName}");
        Console.WriteLine("=== === === === ===");
        Console.WriteLine();
        Console.ResetColor();
    }
    
    public static void PrintTask(Task task)
    {
        switch (task.Status)
        {
            case TaskStatus.Created:
                PrintTaskColor(task, ConsoleColor.Blue);
                break;
            case TaskStatus.Done:
                PrintTaskColor(task, ConsoleColor.Gray);
                break;
            case TaskStatus.InWork:
                PrintTaskColor(task, ConsoleColor.Green);
                break;
            case TaskStatus.Delayed:
                PrintTaskColor(task, ConsoleColor.Yellow);
                break;
            case TaskStatus.Canceled:
                PrintTaskColor(task, ConsoleColor.Red);
                break;
        }
    }
}