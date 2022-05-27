using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , Student> Students = new Dictionary<string , Student>();

            Console.WriteLine("MENU");
            bool check = true;
            string fullName;
            string answer;
            string pointStr;
            int point;
            string no;
            while (check)
            {
                Console.WriteLine("1.Student elave et\n2.Studentleri goster");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Telebenin adini daxil et:");
                            fullName = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fullName));
                        do
                        {
                            Console.WriteLine("Telebenin balini daxil et:");
                            pointStr = Console.ReadLine();
                        } while (!int.TryParse(pointStr, out point));
                        do
                        {
                            Console.WriteLine("Telebenin  nomresini daxil et:");
                            no= Console.ReadLine();
                        } while (Students.ContainsKey(no));
                        Student addedStudent = new Student();
                        addedStudent.FullName = fullName;
                        addedStudent.Point = point;

                        Students.Add(no, addedStudent);
                        break;
                    case "2":
                        foreach (var std in Students)
                        {
                            Console.WriteLine($"{std.Key},{std.Value.FullName},{std.Value.Point}");
                        }
                        break;
                    default:
                        check = false;
                        break;
                }
            }
           

        }
    }
}
