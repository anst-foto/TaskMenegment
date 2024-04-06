namespace TaskMenegment.Models;

public class TaskList
{
    private readonly List<Task> _tasks;

    public TaskList()
    {
        _tasks = new List<Task>();
    }

    public void Add(Task task)
    {
        _tasks.Add(task);
    }

    public void Remove(Task task)
    {
        _tasks.Remove(task);
    }
    
    public IEnumerable<Task> GetAllTasks() => _tasks;

    public IEnumerable<Task> FindAllByExecutor(Person executor)
    {
        var result = new List<Task>();
        foreach (var task in _tasks)
        {
            if (task.Executor == executor)
            {
                result.Add(task);
            }
        }
        return result;
    }

    public IEnumerable<Task> FindAllByStatus(TaskStatus status)
    {
        foreach (var task in _tasks)
        {
            if (task.Status == status)
            {
                yield return task;
            }
        }
    }

    public IEnumerable<Task> FindAllByDeadLine(DateTime deadLine)
    {
        foreach (var task in _tasks)
        {
            if (task.DeadLine == deadLine)
            {
                yield return task;
            }
        }
    }

    public IEnumerable<Task> FindAllByTitle(string title)
    {
        foreach (var task in _tasks)
        {
            if (task.Title == title)
            {
                yield return task;
            }
        }
    }
}