using System;

namespace AccessModifiersQues
{
    class Book
    {
        public string ISBN;
        protected string title;
        private string author;
        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public string GetAuthor()
        {
            return author;
        }
    }
    class EBook : Book
    {
        public EBook(string ISBN, string title, string author)
            : base(ISBN, title, author)
        {

        }

        public void Display()
        {
            Console.WriteLine("ISBN   : " + ISBN);
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author : " + GetAuthor());
        }
    }
}