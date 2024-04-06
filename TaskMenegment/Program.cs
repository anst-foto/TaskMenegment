using TaskMenegment;
using TaskMenegment.Models;
using Task = TaskMenegment.Models.Task;
using TaskStatus = TaskMenegment.Models.TaskStatus;

var person1 = new Person()
{
    FirstName = "John",
    LastName = "Doe"
};

var person2 = new Person()
{
    FirstName = "Jane",
    LastName = "Doe"
};

var tasks = new TaskList();
tasks.Add(new Task()
{
    Title = "Task 1",
    DeadLine = DateTime.Now.AddDays(1),
    Executor = person1
});
tasks.Add(new Task()
{
    Title = "Task 2",
    DeadLine = DateTime.Now.AddDays(2),
    Executor = person2
});
tasks.Add(new Task()
{
    Title = "Task 3",
    DeadLine = DateTime.Now.AddDays(2),
    Executor = person1
});

foreach (var task in tasks.GetAllTasks())
{
    Cli.PrintTask(task);
}

var list = tasks.FindAllByExecutor(person1);
foreach (var task in list)
{
    task.Status = TaskStatus.Done;
    if (task.DeadLine.Date == DateTime.Now.AddDays(2).Date)
    {
        task.Executor = person2;
    }
}

foreach (var task in tasks.GetAllTasks())
{
    Cli.PrintTask(task);
}
