using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Abstraction
{
    public class Car:Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }
        public override void Drive(double km)
        {
            if (CurrentFuel>=km*FuelFor1km)
            {
                Millage += km;
                CurrentFuel -= km * FuelFor1km;
            }
        }
    }
}
