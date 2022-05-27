using System;

namespace ConsoleApp3._1
{
    class Program;
    {
        static void Main(string[] args)
        {
            int number = 15;
            if (number < 0) 
            {
                Console.WriteLine("Menfi");
            } 
            else if (number == 1)
            {
                Console.WriteLine(1);
            }
            for (int i = 0; i * i <= number; i++)
            {
                int result = i - 1;

                Console.WriteLine(result);
            }
           
            
        }
    }
}
