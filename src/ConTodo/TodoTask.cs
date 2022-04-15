namespace ConTodo;

public class TodoTask
{

    public TodoTask(string title)
    {
        Title = title;
        IsInbox = true;
    }

    public string Title { get; }

    public bool IsInbox { get; }

}