using FluentAssertions;

namespace ConTodo.Specflow.Steps;

[Binding]
public class InboxStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly TaskService _taskService;

    public InboxStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _taskService = ConTodoFactory.CreateTaskService();
    }
    [Given(@"There is (.*) item in the inbox")]
    public void GivenThereIsItemInTheInbox(int numberOfItems)
    {
        for (var i = 0; i < numberOfItems; i++)
        {
            _taskService.CreateTask($"Task {i}");
        }
    }

    [When(@"I add a task")]
    public void WhenIAddATask()
    {
        _taskService.CreateTask("New Task");
    }

    [Then(@"There is (.*) item in the inbox")]
    public void ThenThereIsItemInTheInbox(int numberOfItems)
    {
        _taskService.GetTasks().Count.Should().Be(numberOfItems);
    }

    [When(@"I add a task with due date")]
    public void WhenIAddATaskWithDueDate()
    {
        _scenarioContext.Pending();
    }

    [Then(@"The task has a due date")]
    public void ThenTheTaskHasADueDate()
    {
        _scenarioContext.Pending();
    }
}