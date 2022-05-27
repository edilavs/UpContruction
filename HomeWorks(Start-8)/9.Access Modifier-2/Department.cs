using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Access_Modifier_2
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int SalaryLimit { get; set; }
        public Employee[] Employees = new Employee[0];
        public void AddEmployee(Employee employee)
        {
            if (Employees.Length<EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
        }
    }
}
