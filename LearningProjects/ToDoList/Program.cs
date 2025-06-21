using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
    private List<TaskItem> tasks = new List<TaskItem>();

    public void AddTask(string title)
    {
        tasks.Add(new TaskItem { Title = title, IsCompleted = false });
        System.Console.WriteLine("Task Added!");
    }
    public void ShowAllTasks()
    {
        if (tasks.Count == 0)
        {
            System.Console.WriteLine("Zero tasks find");
        }
        System.Console.WriteLine("Todo List:");

        for (int i = 0; i < tasks.Count; i++)
        {
            var status = tasks[i].IsCompleted ? "[✔]" : "[ ]";
            System.Console.WriteLine($"{i + 1}.{status}{tasks[i].Title}");
        }
    }

    public void MarkAsDone(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].IsCompleted = true;
            System.Console.WriteLine("Task marked as done.");
        }
        else
        {
            System.Console.WriteLine("This task is not existed.");
        }
    }

    public void DeleteTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            System.Console.WriteLine($"Task \"{tasks[index].Title}\" deleted");
            tasks.RemoveAt(index);
        }
        else
        {
            System.Console.WriteLine("This task is not existed.");
        }
    }

    public void ShowCompletedTasks()
    {
        var completed = tasks.Where(t => t.IsCompleted).ToList();

        if (completed.Count == 0)
        {
            System.Console.WriteLine("No one task is completed");
            return;
        }

        System.Console.WriteLine("Completed tasks: ");
        foreach (var task in completed)
        {
            System.Console.WriteLine($"[✔] {task.Title}");
        }
    }
}
class Program
{

    static void Main()
    {
        TaskManager manager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== Menu =====");
            Console.WriteLine("1. Add task.");
            Console.WriteLine("2. Show all tasks.");
            Console.WriteLine("3. Mark as done.");
            Console.WriteLine("4. Delete task.");
            Console.WriteLine("5. Show completed tasks.");
            Console.WriteLine("6. Quit.");
            Console.Write("Please do you choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    System.Console.WriteLine("Add task name.");
                    string title = Console.ReadLine();
                    manager.AddTask(title);
                    break;

                case "2":
                    manager.ShowAllTasks();
                    break;

                case "3":
                    System.Console.WriteLine("Enter task №: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manager.MarkAsDone(index - 1);
                    }
                    break;

                case "4":
                    System.Console.WriteLine("Enter task №: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteIndex))
                    {
                        manager.DeleteTask(deleteIndex - 1);
                    }
                    break;

                case "5":
                    manager.ShowCompletedTasks();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    System.Console.WriteLine("WRONG CHOICE");
                    break;
            }
        }
    }
}
