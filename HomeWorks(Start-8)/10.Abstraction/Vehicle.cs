using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Abstraction
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine(Brand+ " "+Color+" "+Millage);
        }
        public abstract void Drive(double km);
       
    }
}
