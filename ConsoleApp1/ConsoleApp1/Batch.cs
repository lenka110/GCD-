using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Batch
    {
        public string Name;
        public List<Student> Students;
        public Batch(string name)
        {
            Name = name;
            Students = new List<Student>();
        }
        public Student FindStudentByID(string id)
        {
            return Students.SingleOrDefault(s => s.Id.Equals(id));
        }
    
        public bool Add(Student student)
        {
            if (FindStudentByID(student.Id) != null)
            {
                return false;
            }
            Students.Add(student);
            return true;
        }
        public bool DeleteStudentById(string id)
        {
            var studentInBatch = FindStudentByID(id);
            if (studentInBatch == null) return false;
            Students.Remove(studentInBatch);
            return true;
        }
        public bool EditStudentById(string id, string fullName, int age)
        {
            var studentInBatch = FindStudentByID(id);
            if (studentInBatch == null) return false;
            studentInBatch.FullName = fullName;
            studentInBatch.Age = age;
            return true;
        }

    }
}