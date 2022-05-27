using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Book:Product
    {
        public Book(string author,double price):base(price)
        {
            this.Author = author;
        }
        public string Author;
        public string Genre;
    }
}
