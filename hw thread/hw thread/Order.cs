using System;
using System.Collections.Generic;
using System.Text;

namespace hw_thread
{
    public class Order
    {
        public Order()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
