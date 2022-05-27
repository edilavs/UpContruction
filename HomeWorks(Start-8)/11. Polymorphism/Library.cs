using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Polymorphism
{
    public class Library
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public Product[] GetProductsByPrice(double minPrice,double maxPrice)
        {
            Product[] newProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.Price>=minPrice &&item.Price <=maxPrice)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = item;
                }
            }
            return newProducts;
        }
        public Product[] GetProductsByName(string value)
        {
            Product[] newProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.Name.Contains(value))
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = item;
                }
            }
            return newProducts;
        }
    }
}
