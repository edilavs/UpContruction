using System;

namespace ConsoleApp11
{
    class Book : Product
    {

        public Book(string author, double price) : base(price)
        {
            this.Author = author;
            Console.WriteLine($"Author:{Author}");
        }
        public string Author;
        public string Gendre;
    }
}
