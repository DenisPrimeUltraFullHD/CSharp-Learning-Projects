using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Models;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TasksController : ControllerBase
    {

        private static readonly List<TaskItem> Tasks = new();
        private static int _nextId = 1;

        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> GetAll()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskItem> GetById(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskItem> Create(TaskItem newTask)
        {
            newTask.Id = _nextId++;
            Tasks.Add(newTask);
            return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskItem updatedTask)
        {
            var existingTask = Tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask == null)
                return NotFound();

            existingTask.Title = updatedTask.Title;
            existingTask.Description = updatedTask.Description;
            existingTask.IsCompleted = updatedTask.IsCompleted;

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound();
            Tasks.Remove(task);
            return NoContent();
        }
    }
}