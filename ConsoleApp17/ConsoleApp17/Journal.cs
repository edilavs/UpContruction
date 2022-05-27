using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Journal:Product
    {
        public Journal(double price):base(price)
        {

        }
        public string Title;
        public string Month;
    }
}
