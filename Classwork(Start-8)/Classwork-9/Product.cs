using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_9
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double TotalInCome { get; set; }

        public void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalInCome += Price;
            }
        }

    }
}
