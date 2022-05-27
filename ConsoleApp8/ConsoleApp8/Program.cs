using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("soz daxil edin:");
            string word = Console.ReadLine();

            Console.WriteLine(StringWithoutSpace(word));

        }
        static string StringWithoutSpace(string word)
        {
            char space = ' ';

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == space)
                {
                    return null;
                }

            }
            return word;


        }
    }
}
   
