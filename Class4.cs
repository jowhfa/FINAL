using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public static class TaskManager
    {
        private static ArrayList tasks = new ArrayList();

        public static void AddTask(Task task)
        {
            tasks.Add(task);

        }
        public static void DeleteTask(Task task)
        {
            tasks.Remove(tasks);
        }
    }
}