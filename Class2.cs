using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
        class Program
        {
            static void Main(string[] args)
            {
                // إنشاء مهمة جديدة
                Task task1 = new Task();
                task1.name = "eat foood.";

                // إضافة المهمة إلى TaskManager
                TaskManager.AddTask(task1);

                // طباعة اسم المهمة
                task1.PrintTask();

                // بحث عن المهمة
                int index = TaskManager.SearchForTask(task1);
                Console.WriteLine("Task found at index: " + index);

                // حذف المهمة
                TaskManager.DeleteTask(task1);

                // بحث عن المهمة بعد الحذف
                index1 = TaskManager.SearchForTask(task1);
                Console.WriteLine("Task found at index: " + index1);

                Console.ReadLine();

                // إنشاء مهمة جديدة
                Task task2 = new Task();
                task2.name = "go to sleep";

                // إضافة المهمة إلى TaskManager
                TaskManager.AddTask(task2);

                // طباعة اسم المهمة
                task1.PrintTask();

                // بحث عن المهمة
                int index = TaskManager.SearchForTask(task2);
                Console.WriteLine("Task found at index: " + index);

                // حذف المهمة
                TaskManager.DeleteTask(task2);

                // بحث عن المهمة بعد الحذف
                index = TaskManager.SearchForTask(task2);
                Console.WriteLine("Task found at index: " + index);

                Console.ReadLine();


            }
        }
