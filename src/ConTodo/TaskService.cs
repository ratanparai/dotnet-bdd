namespace ConTodo;

public class TaskService
{
    private readonly InboxRepository _inboxRepository;

    public TaskService(InboxRepository inboxRepository)
    {
        _inboxRepository = inboxRepository;
    }
    
    public void CreateTask(string title)
    {
        var task = new TodoTask(title);
        _inboxRepository.AddTask(task);
    }

    public IReadOnlyCollection<TodoTask> GetTasks()
    {
        return _inboxRepository.GetTasks();
    }
}