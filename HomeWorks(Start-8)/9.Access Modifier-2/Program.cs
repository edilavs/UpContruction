using System;

namespace _9.Access_Modifier_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Hikmet";
            employee1.Surname = "Abbasov";
            employee1.Salary = 780;

            Department department = new Department();
            department.Name = "depName";
            department.EmployeeLimit = 89;
            department.SalaryLimit = 100;
           
            department.AddEmployee(employee1);
            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.Name +" "+item.Surname +" "+item.Salary);
            }

        }
    }
}
