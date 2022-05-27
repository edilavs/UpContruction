using System;

namespace _10.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("daxil edilecek masinlarin sayini yazin:");
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                cars[i] = new Car();
                Console.WriteLine($"{i+1}.ci masinin brandi daxil edin:");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}.ci masinin rengini daxil edin:");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1}.ci masinin millage-ni daxil edin:");
                double millage = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci masinin CurrentFuel-ni daxil edin:");
                double currentFuel = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci masinin 1km ucun lazim olacaq bezin miqdarini daxil edin:");
                double fuelFor1km = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci masinin FuelCapacity-ni daxil edin:");
                double fuelCapacity = int.Parse(Console.ReadLine());
            }
            bool check = true;
            string answer;
            
            
            while (check)
            {
                Console.WriteLine("1. Masınları millage-e gore filtirle\n2.Butun masınları goster\n3.Prosesi bitir");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                       
                        Console.WriteLine("Millage ucun min deyer:");
                        double minMil = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Millage ucun max deyer:");
                        double maxMil = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < cars.Length; i++)
                        {
                            int counter = 0;
                            if (cars[i].Millage >= minMil && cars[i].Millage <= maxMil)
                                counter++;
                            if (counter > 0)
                                Console.WriteLine($"{cars[i].Brand} - {cars[i].Millage}");
                        }
                        
                        break;
                    case "2":
                        for (int i = 0; i < cars.Length; i++)
                        {
                            Console.WriteLine(cars[i].Brand);
                        }
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi!");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("uygun secim edin:");
                        break;
                }
            }
        }
    }
}
