using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_9
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Car yaradildi!");
        }
        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model,string color,double maxspeed):this(brand,model)
        {
            Color = color;
            Maxspeed = maxspeed;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Maxspeed { get; set; }
        public virtual string GetInfo()
        {
            return Brand + " " + Model + " " + Color + " " + Maxspeed;
        } 

    }
}
