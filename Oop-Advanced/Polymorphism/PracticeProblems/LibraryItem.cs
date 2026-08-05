using System;

namespace PracticeProblems
{
    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        private string borrowerName;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public LibraryItem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
            borrowerName = "";
        }
        public abstract int GetLoanDuration();
       public void GetItemDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Item ID : {ItemId}");
            Console.WriteLine($"Title   : {Title}");
            Console.WriteLine($"Author  : {Author}");
        }
    }

    class Book : LibraryItem, IReservable
    {
        private bool available = true;
        public Book(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem()
        {
            available = false;
            Console.WriteLine("Book Reserved Successfully.");
        }
        public bool CheckAvailability()
        {
            return available;
        }
    }
    class Magazine : LibraryItem, IReservable
    {
        private bool available = true;
        public Magazine(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }
        public void ReserveItem()
        {
            available = false;
            Console.WriteLine("Magazine Reserved Successfully.");
        }
        public bool CheckAvailability()
        {
            return available;
        }
    }

    class DVD : LibraryItem, IReservable
    {
        private bool available = true;
        public DVD(int id, string title, string author)
            : base(id, title, author)
        {
        }
        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            available = false;
            Console.WriteLine("DVD Reserved Successfully.");
        }
        public bool CheckAvailability()
        {
            return available;
        }
    }
}