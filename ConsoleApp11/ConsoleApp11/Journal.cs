using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Journal:Book
    {
        public Journal( string author,double price) : base(author,price)
        {
            this.Author = author;

        }
        public string Month;
        public string title;

    }
}
