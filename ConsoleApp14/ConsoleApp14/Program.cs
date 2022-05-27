using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Başlangıç değeri: {0}", value);
            Kare(value);
            Console.WriteLine("Kare() sonrası: {0}", value);
            Kare2( ref value);
            Console.WriteLine("Kare2() sonrası: {0}", value);
        }
        static void Kare(int num)
        {
           num = num * num;
        }

        static void Kare2(ref int num)
        {
          num= num * num;
        }
    }
}
