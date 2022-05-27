using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Product
    {   
        public Product(double price)
        {
            this.Price = price;
        }
        public Product ( double price,double discountPercent)
        {
            this.Price = price;

            DiscountedPrice = Price - (discountPercent * Price);
        }
        public string Name;
        public double Price;
        public double DiscountedPrice;
        public string GetInfo()
        {
            return Name + " " + Price;
        }
    }
}
