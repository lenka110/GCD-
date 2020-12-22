using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Id;
        public string FullName;
        public int Age;

        public Student(string id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Full Name:{FullName}");
            Console.WriteLine($"Age:{Age}");
        }
    }
}
