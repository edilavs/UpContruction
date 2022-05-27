using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_9
{
    public class Milk:Product 
    {
        public Milk(string name):base(name)
        {

        }
        public double Volume { get; set; }
        public double FatRate { get; set; }
    }
}
