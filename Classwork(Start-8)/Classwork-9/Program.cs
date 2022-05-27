using System;

namespace Classwork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //Car car = new Car();
            //car.Model = "mercedes";
            //car.Brand = "S800";
            //car.Color = "gray";
            //car.Maxspeed = 250;
            //Console.WriteLine(car.GetInfo());

            //Bus bus = new Bus("Feat", "feeeaat", 12);
            //Console.WriteLine(bus.GetInfo());
            #endregion

            #region Task-2
            Product product = new Product("Corek");
            product.Count = 70;
            product.Price = 0.75;

            Product product2 = new Product("Et");
            product2.Count = 120;
            product2.Price = 14;

            Product product3 = new Product("banan");
            product3.Count = 80;
            product3.Price = 2.65;

            product3.Sell();
            product3.Sell();
            Console.WriteLine(product3.TotalInCome);



            #endregion

        }
    }
}
