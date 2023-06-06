using System;
using System.Collections;

namespace ConsoleApplication4
{
    public class Task
    {
        public String name;
        public Task(String name)
        {
            this.name = name;
        }
        public void PrintTask()
        {

            Console.WriteLine("Task Name:" + name);
        }
    }

    public static class TaskManager
    {
        private static ArrayList tasks = new ArrayList();

        public static void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added successfuiiy");
        }
        public static void DeleteTask(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task not found!.");
            }
        }
        public static int SearchForTask(Task task)
        {
            int index = tasks.IndexOf(task);
            if (index != -1)
            {
                Console.WriteLine("Task found at index:" + index);
            }
            else
            {
                Console.WriteLine("Task not found!.");
            }
            return index;

        }

    }
}

