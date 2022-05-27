using System;

namespace HomeWorks_Start_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string password;
            Console.WriteLine("UserName daxil edin:");
            userName = Console.ReadLine();
            Console.WriteLine("Password daxil edin:");
            password = Console.ReadLine();
            User user1 = new User(userName);
            user1.Password = password;
            Console.WriteLine($"USERNAME:{user1.UserName}\nPASSWORD:{user1.Password}");
          
        }
    }
}
