using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("soz daxil ed");
            string word = Console.ReadLine(); ;
            Console.WriteLine(HasDigit (word ));
        }
        static bool HasDigit(string text)
        {
            bool check = false;
            for (int i= 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                    check = true;
            }
            return check;
        }
    }
}
