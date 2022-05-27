using System;

namespace ConsoleApppractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adlarin sayini daxil edin:");
            //string namesCountStr = Console.ReadLine();
            //int namesCount = Convert.ToInt32(namesCountStr);
            ////int namesCount=Convert.ToInt32(Console.ReadLine());
            //string[] names = new string[namesCount];

            //for (int i = 0; i < namesCount; i++)
            //{
            //    Console.WriteLine($"{i+1}ci adi daxil et:");
            //    names[i] = Console.ReadLine();

            //}
            Console.WriteLine("deyer daxil edin:");
            string val = Console.ReadLine();

            char[] digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < val.Length; i++)

            {
                for (int j = 0; j < val.Length; j++)
                {


                    if (val[i] == digit[j])
                        Console.WriteLine("reqem var");
                   
                     

                }
               
                        Console.WriteLine("yoxdur");





                //string[] names = { "Ayan", "Atilla", "Gwnes", "jamal", "Ayten" };
                //int counter = 0;
                //for(int i = 0; i < names.Length; i++)
                //{
                //    if(names[i][0]=='A')
                //    {
                //        counter++;
                //    }
                //}
                //string[] newNames = new string[counter];
                //int j = 0;
                //for (int i = 0; i < names.Length; i++)
                //{
                //    if (names[i][0] == 'A')
                //    {
                //        newNames[j] = names[i];
                //        j++;
                //    }
                //}
                //foreach(var item in newNames)
                //{
                //    Console.WriteLine(item);
                //}
            }

        }
    }
}
