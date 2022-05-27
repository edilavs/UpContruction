using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Access_Modifier_2
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;
        public string Name
        {
            get => _name; 
            set
            {
                if (AllIsLetter(value)&&char.IsUpper (value[0]))
                {
                    _name = value;
                }; 
            } 
        }
        public string Surname
        {
            get => _surname; set
            {
                if (AllIsLetter(value) && char.IsUpper(value[0]))
                {
                    _surname = value;
                }; 
            } 
        }
        public double Salary
        {
            get => _salary; set
            {
                if (value>=250)
                {
                    _salary = value;
                }
            }
        }

        public bool AllIsLetter(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                }
            }
            if (str.Length == count)
                return true;
            else
                return false;
        }
    }
}
