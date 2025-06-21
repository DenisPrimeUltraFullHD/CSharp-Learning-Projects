using WebApiWithDb.Models;

namespace WebApiWithDb.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem? GetById(int id);
        TaskItem Create(TaskItem item);
        bool Update(int id, TaskItem item);
        bool Delete(int id);
    }
}
