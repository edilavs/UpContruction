using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Notebook:Product

    {
        public Notebook(string model, int count, double price) : base(count,price)
        {
            this.Model = model;
        }
        public string Model;
        public string Brand ;
        public int RAM;
        public int Storage;
         
       public string GetInfo()
        {
            return $"Brand:{Brand} Model: {Model} RAM:{RAM} Storage:{Storage} ";
        }
    }
}
