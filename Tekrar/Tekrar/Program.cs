using System;

namespace Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 15, 23, 45, 98, 78 };
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int teklik = number[i] % 10;
                int onluq = number[i] / 10;
                sum = teklik + onluq;
                int counter = 0;
                if (sum < 10)
                {
                    counter++;
                    Console.WriteLine(counter);
                }
            }
           
            Console.WriteLine($"Lazim olan ededlerin sayi:{counter}");
        }
          
    }
}
        
