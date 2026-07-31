using System;

namespace Level1
{
    class LibrarySystem
    {
        string title;
        string author;
        double price;
        bool available;

        public LibrarySystem(string title,string author,double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            available = true;
        }

        public void BorrowBook()
        {
            if (available)
            {
                available = false;
                Console.WriteLine("\nBook Borrowed Successfully");
            }
            else
            {
                Console.WriteLine("\nBook is already borrowed");
            }
        }

        public void Display()
        {
            Console.WriteLine("\nTitle : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Available : " + available);
        }
    }
}