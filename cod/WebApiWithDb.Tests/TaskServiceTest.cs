using WebApiWithDb.Models;
using WebApiWithDb.Services;
using Xunit;

namespace WebApiWithDb.Tests
{
    public class TaskServiceTests
    {
        private readonly TaskService _service;

        public TaskServiceTests()
        {
            _service = new TaskService();
        }

        [Fact]
        public void Create_ShouldAssignIdAndAddToList()
        {
            var task = new TaskItem { Title = "Test Task", IsCompleted = false };

            var createdTask = _service.Create(task);

            Assert.NotNull(createdTask);
            Assert.True(createdTask.Id > 0);
            Assert.Equal("Test Task", createdTask.Title);
        }

        [Fact]
        public void GetAll_ShouldReturnAllTasks()
        {
            _service.Create(new TaskItem { Title = "One" });
            _service.Create(new TaskItem { Title = "Two" });

            var tasks = _service.GetAll();

            Assert.Equal(2, tasks.Count());
        }

        [Fact]
        public void GetById_ShouldReturnCorrectTask()
        {
            var task = _service.Create(new TaskItem { Title = "Find Me" });

            var found = _service.GetById(task.Id);

            Assert.NotNull(found);
            Assert.Equal("Find Me", found.Title);
        }

        [Fact]
        public void Delete_ShouldRemoveTask()
        {
            var task = _service.Create(new TaskItem { Title = "Delete Me" });

            _service.Delete(task.Id);
            var result = _service.GetById(task.Id);

            Assert.Null(result);
        }

        [Fact]
        public void Update_ShouldModifyExistingTask()
        {
            var task = _service.Create(new TaskItem { Title = "Old", IsCompleted = false });

            var updated = new TaskItem { Title = "New", IsCompleted = true };
            var result = _service.Update(task.Id, updated);

            Assert.True(result);
            var fetched = _service.GetById(task.Id);
            Assert.Equal("New", fetched.Title);
            Assert.True(fetched.IsCompleted);
        }
    }
}
