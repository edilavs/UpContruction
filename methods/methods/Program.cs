using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Ededi daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Ededi daxil edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Sum(num1, num2);
            Console.WriteLine($"Ededlerin cemi:{result}");
            int[] nums = { 12, 13, 45, 6, 7 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = Sum(sum, nums[i]);
                // int result2 = 0;
                //result2 = Sum(sum, nums[i]);

            }
            Console.WriteLine($"arraydaki ededlerin cemi: {sum}");
            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            string surname = Console.ReadLine();
            string fullName = MakeFullName(name, surname);
            Console.WriteLine($"tam ad: {fullName}");
            HasDigit("salam necesen?;");
            HasDigit("salam 13 ;");
            Console.WriteLine("eded daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isEven = IsEven(number);
            Console.WriteLine($"Verilen eded cutdurmu?---{isEven}");
            Console.WriteLine("Arraydaki elementlerin sayini daxil et:");
            int counter = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[counter];
            for (int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine($"{i+1}ci elementi daxil edin:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int countEven = CountOfEvenNumbers(numbers);
            Console.WriteLine($"Cut ededlerin sayi:{countEven}");

            


            


        }
        static int Sum(int num1,int  num2)
        {
            int result = num1 + num2;
            return result;
        }
        static string MakeFullName(string name,string surname)
        {
            string fullName = name + " "+surname;
            return fullName;
        }
        static void Print( string output)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < output.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if (output[i] == numbers[j])
                    {
                        return;
                    }
                }

            }
            Console.WriteLine(output);
        }
        static bool HasDigit(string output)
        {
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < output.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if (output[i] == numbers[j])
                        return true;
                }
            }
            return false;

        }
        static bool IsEven( int num1) {
            if (num1 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        static int CountOfEvenNumbers(int [] array)
        {
            int counter = 0;
            foreach(var item in array)
            {
                if (item % 2 == 0)
                    counter++;
            }
            return counter;
        } 

    }
}
