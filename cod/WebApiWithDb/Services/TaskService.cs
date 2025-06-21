using WebApiWithDb.Models;

namespace WebApiWithDb.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public TaskItem? GetById(int id) =>
            _tasks.FirstOrDefault(t => t.Id == id);

        public TaskItem Create(TaskItem item)
        {
            item.Id = _nextId++;
            _tasks.Add(item);
            return item;
        }

        public bool Update(int id, TaskItem item)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Title = item.Title;
            existing.Description = item.Description;
            existing.IsCompleted = item.IsCompleted;
            return true;
        }

        public bool Delete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;

            _tasks.Remove(task);
            return true;
        }
    }
}
