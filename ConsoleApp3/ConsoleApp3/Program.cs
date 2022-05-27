using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 35;
           

            if (number < 0)
            {
                Console.WriteLine("Menfidir");
            }
            else if( number == 1)
            {
                Console.WriteLine("1");
            }
            for(int i = 2;i<number;i++)
            {
                while (i * i <= number) {
                    int result = i - 1;
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine("netice " +result );
        }
    }
}
