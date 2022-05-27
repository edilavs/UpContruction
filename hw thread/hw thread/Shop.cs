using System;
using System.Collections.Generic;
using System.Text;

namespace hw_thread
{
    public class Shop
    {
        public List<Order> Orders = new List<Order>();

        public void AddOrder(Order Ord)
        {
            Orders.Add(Ord);
        }
        public double GetOrdersAvg()
        {
            double sum = 0;
            int count = 0;
            foreach (var order in Orders)
            {
                count++;
                sum += order.TotalAmount/order.ProductCount;
            }
            return sum / count;
        }
        public double GetOrdersAvgByDate(DateTime date)
        {
            double sum = 0;
            int count = 0;
            foreach (var ord in Orders)
            {
                if (ord.CreatedAt >date)
                {
                    count++;
                    sum += ord.TotalAmount / ord.ProductCount;
                }
            }
            return sum / count;
        }
        public void RemoveOrderByNo(int no)
        {
            if (Orders.Exists(x=>x.No==no))
            {
                Orders.Remove(Orders.Find(x => x.No == no));
            }
        }
        public List <Order> FilterOrderByPrice(double minPrice,double maxprice)
        {
            return Orders.FindAll(x => x.TotalAmount/x.ProductCount >= minPrice && x.TotalAmount/x.ProductCount <= maxprice);
        }
    }
}
