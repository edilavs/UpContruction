using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Abstraction
{
    public class Bycle:Vehicle 
    {
        public override void Drive(double km)
        {
            Millage+=km;
        }

        
    }
}
