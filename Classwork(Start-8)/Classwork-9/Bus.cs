using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_9
{
    public class Bus:Car
    {
        public Bus(string model,string brand,int pessengerCount):base(brand,model)
        {
            PessengerCount = pessengerCount;
        }
        public int PessengerCount { get; set; }
        public override string GetInfo()
        {
            return PessengerCount+" " + Brand + " " + Model + " " + Color + " " + Maxspeed;
        }
    }
}
