using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_Start_8_
{
    public class Student
    {
        public Student(double point)
        {
            this.Point = point;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNo { get; set; }
        public double Point { get; set; }
        public bool IsGraduated = true;
        public void FullName()
        {
            Console.WriteLine(Name + " " + Surname); 
        }
        public void EveryData()
        {
            Console.WriteLine($"{Name }-{Surname }-{GroupNo}-{Point}");
            if (IsGraduated)
            {
                Console.WriteLine("Mezun olub.");
            }
            else
                Console.WriteLine("mezun olmayib.");
        }
        public void NextExam()
        {
            if (Point>80)
            {
                Console.WriteLine("Novbeti imtahana gire bilersiz.");
            }
            else
                Console.WriteLine("Imtahana buraxilmaq ucun yeterli bal deyil.");
        }
    }
}
