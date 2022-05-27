using System;

namespace hw_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.ProductCount = 5;
            order1.TotalAmount = 40;
            order1.CreatedAt = new DateTime(2022, 10, 15);

            Order order2 = new Order();
            order2.ProductCount = 6;
            order2.TotalAmount = 60;
            order2.CreatedAt = new DateTime(2022, 11, 10);

            Order order3 = new Order();
            order3.ProductCount = 4;
            order3.TotalAmount = 36;
            order3.CreatedAt = new DateTime(2020, 8, 15);

            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            Console.WriteLine("Ortalama:");
            Console.WriteLine(shop.GetOrdersAvg());
            Console.WriteLine("Ortalama by date:");
            Console.WriteLine(shop.GetOrdersAvgByDate(new DateTime(2020, 8, 15))); 
            Console.WriteLine("Before>Order listi:");
            foreach (var ord in shop.Orders)
            {
                Console.WriteLine(ord.No +" "+ord.TotalAmount +" "+ord.ProductCount);
            }
            shop.RemoveOrderByNo(2);
            Console.WriteLine( "After>Orderlist:" );
            foreach (var ord in shop.Orders)
            {
                Console.WriteLine(ord.No + " " + ord.TotalAmount + " " + ord.ProductCount);
            }
            shop.RemoveOrderByNo(2);

            Console.WriteLine("Filterleme:");
            foreach (var item in shop.FilterOrderByPrice(7, 11))
            {
                Console.WriteLine(item.ProductCount+" "+item.No );
            }
            






        }
    }
}
