using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
