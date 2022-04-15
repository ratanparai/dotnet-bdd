namespace ConTodo;

public class InboxRepository
{
    private readonly List<TodoTask> _tasks = new();

    public void AddTask(TodoTask task)
    {
        _tasks.Add(task);
    }

    public IReadOnlyCollection<TodoTask> GetTasks()
    {
        return _tasks.AsReadOnly();
    }
}