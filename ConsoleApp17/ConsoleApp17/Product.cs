using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Product
    {
        public Product(double price)
        {
            this.Price = price;
        }
        public Product(double price,double discountPercent)
        {
            this.Price = price;
            this.DiscountedPrice =price-price*discountPercent;
        }
        public string Name;
        public double Price;
        public double DiscountedPrice;
        
        public string GetInfo()
        {
            return Name + " " + Price + " " +DiscountedPrice;
        }
    }
}
