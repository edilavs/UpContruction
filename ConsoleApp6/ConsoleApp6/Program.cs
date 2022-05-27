using System;

namespace ConsoleApp6
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            string[] names = { "Ayla", "Gunes", "Ayxan" , "Aybeniz" ,"Lamie" };
            char firstLetter = 'A';
            int counter = 0;
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i][0] == firstLetter)
                {
                    counter++;
                    Console.WriteLine(names[i]);
                    //Console.WriteLine("adlar bunlardir:" +names[i]);
                }
            }
            string[] newNames =new string [counter];
            int j = 0;
            for (int i = 0; i < names.Length; i++) 
            {

                if (names[i][0] == firstLetter)
                {
                    newNames[j] = names[i];
                    j++;
                }
            }
                Console.WriteLine("new array:" );
            foreach (var item in newNames)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine();
        }
    }
}
