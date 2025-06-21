namespace testlearnTEST;

public class TaskManagerTests
{
    [Fact]
    public void Add_ShouldAssignIdAndStoreTask()
    {
        var manager = new TaskManager();

        var addedTask = manager.Add("Learn xUnit")

        Assert.True(addedTask.Id > 0);
        Assert.Equal("Learn xUnit", addedTask.Title);
        Assert.Contains(addedTask, manager.GetAll());
    }
}
