using System;

namespace Tekrar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siyahida olan sozlerin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] word = new string[count];
            int digitCount = 0;
            char[] digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{i+1}.ci elementi daxil et:");
                word[i] = Console.ReadLine();
                for (int j = 0; j < digit.Length; j++)
                {
                    for (int k = 0; k < word[i].Length; k++)
                    {
                        if (word[i][k] == digit[j])
                        digitCount++;
                        break;
                    }
                }
            }
            Console.WriteLine(digitCount);
        }
    }
}
