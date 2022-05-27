using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks_Start_8_
{
    public class User
    {
        public User(string userName)
        {
            this.UserName = userName;
        }
        private string _username;
        public string UserName
        {
            get => _username; 
            set
            {
                if (!String.IsNullOrWhiteSpace(value)&& value.Length>=6 && value.Length <= 25)
                {
                    _username = value;
                }
            } 
        }

        private string _password;
        public string Password
        {
            get => _password; 
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length>=8&& value.Length<=25&&HasDigit(value) &&HasLowerLetter(value) &&HasUpperLetter(value))
                {
                    _password = value;
                } 
            } 
        }

        static bool HasDigit(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool HasUpperLetter(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsUpper(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool HasLowerLetter(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsLower(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
