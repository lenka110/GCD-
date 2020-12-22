using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UI
    {
        public static void ShowStudentInfo(Student student)
        {
            student.ShowInfo();
            Console.WriteLine("***************************");
        }
        public static void ShowbatchInfo(Batch batch)
        {
            Console.WriteLine($"Batch Name:{batch.Name}");
            Console.WriteLine($"Number student in batch:{batch.Students.Count}student");
            Console.WriteLine($"***************************");
            foreach (var student in batch.Students)
            {
                student.ShowInfo();
            }
        }
        public static string EnterStudentId()
        {
            Console.WriteLine("Please enter student Id: ");
            return Console.ReadLine();
        }
        public static string EnterStudentFullName()
        {
            Console.WriteLine("Please enter FullName student: ");
            return Console.ReadLine();
        }
        public static int EnterStudentAge()
        {          
                Console.WriteLine("Please enter the age");             
            return int.Parse(Console.ReadLine());
        }
        public static string DeleteStudentById()
        {
            Console.WriteLine("Please enter the ID you want delete");
            return Console.ReadLine();
        }
        public static string EditStudentById()
        {
            Console.WriteLine("Please enter the ID you want edit");
            return Console.ReadLine();
        }
        public static void ShowMenuControl()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please choose your command control below");
            Console.WriteLine("| 1. Add new student      |");
            Console.WriteLine("| 2. Find student by Id   |");
            Console.WriteLine("| 3. Delete student by Id |");
            Console.WriteLine("| 4. Edit student by Id   |");
            Console.WriteLine("| 5. Exit                 |");
            Console.WriteLine("| 0. Show student list    |");
            Console.WriteLine("--------------------------------------");
        }
        public static int EnterOption()
        {
            Console.Write("Enter your option:");
            return int.Parse(Console.ReadLine());
        }
    }
}
