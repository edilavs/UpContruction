using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Polymorphism
{
    public class Journal : Product
    {
        public string Company { get; set; }
        public override string GetInfo()
        {
            return Name +" "+Company;
        }
    }
}
