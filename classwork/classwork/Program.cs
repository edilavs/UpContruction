using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 88;
            string word = "hellooooo!";
            Console.WriteLine(num.IsOdd());
            Console.WriteLine(num.IsEven());
            Console.WriteLine(word.ToCapitalize());


            //foreach (var item in word.GetValueIndexes('o'))
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in word.GetValueIndexes('o'))
            {
                Console.WriteLine(item);
            }


            foreach (var item in word.GetValueIndexes2('h'))
            {
                Console.WriteLine(item);
            }


        }
    }
}
