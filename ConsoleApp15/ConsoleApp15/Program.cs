using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            int result = 0;
            if (number < 0)
                Console.WriteLine("eded menfidir!");
            else if (number == 0)
                Console.WriteLine(0);
            else if (number == 1)
                Console.WriteLine(1);
            for (int i = 1; i*i <= number; i++) 
            {
                result = i; 
            }
            Console.WriteLine($"en yaxin kok alti deyer:{result}");
        }
    }
}
