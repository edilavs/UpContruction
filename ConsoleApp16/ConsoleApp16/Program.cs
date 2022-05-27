using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededi daxil et:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"eded cutdurmu?-{IsEven(num)}");
            int[] numbers = { 56, 7, 13, 98, 20, 24, 19 };
            Console.WriteLine($"arraydaki cut ededlerin sayi:{CountOfEvenNums(numbers)}");
                
                
        }
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
        static int CountOfEvenNums(int[] arr)
        { 
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }
            return count;
        }
    }
}
