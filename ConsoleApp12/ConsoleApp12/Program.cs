using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 346;
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("Number is even!");
                    break;
                case 1:
                    Console.WriteLine("Number is not even!");
                    break;
            }
            for(int i = 0; i < 100; i++)
            {
                int onluq = i / 10;
                int teklik = i % 10;
                int reqemlerinCemi = onluq + teklik;
                if (reqemlerinCemi > 10)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
