using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = { "Hikmet","Aydan","Laman","Nazim" };
            ChangeTheLastName ( namesArray, "Gulbahar");
            Console.WriteLine ("Names:");
            foreach (var item in namesArray)
            {
                Console.WriteLine(item);
            }
            string word = "Hello,";
            AddToString( ref word, "World");
            Console.WriteLine( word);
        }
        static void ChangeTheLastName(string [] arr,string name)
        {
            string[] newNames = new string[arr.Length];
            arr= newNames;
            arr[arr.Length - 1] = name;
        }
        static void AddToString(  ref string str,string additionalStr)
        {
            str = str + additionalStr;
        }
    }
}
