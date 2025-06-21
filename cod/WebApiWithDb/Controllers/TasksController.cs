using Microsoft.AspNetCore.Mvc;
using WebApiWithDb.Models;
using WebApiWithDb.Services;

namespace WebApiWithDb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> GetAll() =>
            Ok(_taskService.GetAll());

        [HttpGet("{id}")]
        public ActionResult<TaskItem> GetById(int id)
        {
            var task = _taskService.GetById(id);
            return task is null ? NotFound() : Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskItem> Create(TaskItem newTask)
        {
            var created = _taskService.Create(newTask);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskItem updatedTask) =>
            _taskService.Update(id, updatedTask) ? NoContent() : NotFound();

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            _taskService.Delete(id) ? NoContent() : NotFound();
    }
}
