using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Notebook novlerinin sayini daxil edin:");
            int notebookCount = Convert.ToInt32(Console.ReadLine());

            Notebook[] notebooks = new Notebook[notebookCount ];

            for (int i = 0; i < notebookCount; i++)
            {
                string model;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun modelini daxil edin:");
                    model = Console.ReadLine();
                } while (model == null || model.Length < 3 || model.Length > 30);

                string brand;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun brandini daxil edin:");
                    brand = Console.ReadLine();
                } while (brand == null || brand.Length < 3 || brand.Length > 30);

                double price;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun priceni daxil edin:");
                    price = Convert.ToDouble(Console.ReadLine());
                } while (price < 0);

                int ram;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun RAM-ini daxil edin:");
                    ram = Convert.ToInt32(Console.ReadLine());
                } while (ram < 0 || ram  > 128);

                int storage;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun yaddasini daxil edin:");
                    storage = Convert.ToInt32(Console.ReadLine());
                } while (storage < 0);

                int count;
                do
                {
                    Console.WriteLine($"{i + 1}. notebookun sayini daxil edin:");
                    count = Convert.ToInt32(Console.ReadLine());
                } while (count < 0);

                notebooks[i] = new Notebook(model, count, price)
                {
                    Brand = brand,
                    RAM = ram,
                    Storage = storage,
                };
            }
            foreach (var item in notebooks)
            {
                Console.WriteLine($"{item.GetInfo()}");
            }

        }
    }
}
