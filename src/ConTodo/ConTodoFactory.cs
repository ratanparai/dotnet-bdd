namespace ConTodo;

public class ConTodoFactory
{
    public static TaskService CreateTaskService()
    {
        var inboxRepository = new InboxRepository();
        return new TaskService(inboxRepository);
    }
}