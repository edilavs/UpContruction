using System;

namespace Classwork_Start_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(90);
            student.Name = "Hikmet";
            student.Surname = "Abbasov";
            student.GroupNo = "BP202";
            student.IsGraduated = false;

            Student student2 = new Student(87);
            student2.Name = "Tofiq";
            student2.Surname = "Qulamov";
            student2.GroupNo = "AP202";
            student2.IsGraduated = true;

            student.FullName();
            student2.FullName();
            student2.EveryData();

        }
    }
}
