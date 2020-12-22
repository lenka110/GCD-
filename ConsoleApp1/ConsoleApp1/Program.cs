using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            Batch batch = new Batch("GCD0808");
            batch.Add(new Student("GCD19996", "Huynh sau", 16));
            

            UI.ShowMenuControl();
            int option;
            do
            {
                option = UI.EnterOption();
                switch (option)
                {
                    case 1:
                        string studentId = UI.EnterStudentId();

                        string fullName = UI.EnterStudentFullName();

                        int age = UI.EnterStudentAge();

                        var message = batch.Add(new Student(studentId, fullName, age)) ?
                            "SUCESS" : "FAIL";

                        Console.WriteLine(message);
                        break;

                    case 2:
                        studentId = UI.EnterStudentId();
                        if (batch.FindStudentByID(studentId) != null)
                            UI.ShowStudentInfo(batch.FindStudentByID(studentId));
                        else
                            Console.WriteLine("Student not found");
                        break;
                    case 3:

                        studentId = UI.DeleteStudentById();
                        batch.DeleteStudentById(studentId);
                        break;
                    case 4:
                        studentId = UI.EditStudentById();

                        batch.EditStudentById(UI.EnterStudentId(),
                                              UI.EnterStudentFullName(),
                                              UI.EnterStudentAge());
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    case 0:
                        UI.ShowbatchInfo(batch);
                        break;
                    default:
                        Console.WriteLine("try again");
                        break;

                }
            } while (option != 5);
            Console.ReadLine();
        }

    }
}
