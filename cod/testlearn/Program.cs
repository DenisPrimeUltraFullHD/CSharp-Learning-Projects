using System;

class Program
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    static void Main()
    {
        private readonly List<TaskItem> _tasks = new();
    private int _nextId = 1;

    public TaskItem Add(string title)
    {
        var task = new TaskItem
        {
            Id = _nextId++;
            Title = title
        };
        _tasks.Add(task);
        return task;
    }
    public List<TaskItem> GetAll()
    {
        return _tasks
         }

}
}
