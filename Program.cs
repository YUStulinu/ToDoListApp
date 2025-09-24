using System; 
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== TO-DO LIST =====");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show all tasks");
            Console.WriteLine("3. Remove task");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ShowTasks(); break;
                case "3": RemoveTask(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added!");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("Your tasks:");
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"{i + 1}. {tasks[i]}");
    }

    static void RemoveTask()
    {
        ShowTasks();
        Console.Write("Enter the task number to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task removed!");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
