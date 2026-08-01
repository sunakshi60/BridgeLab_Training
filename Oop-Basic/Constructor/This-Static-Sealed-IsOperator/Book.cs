using System;

namespace This_Static_Sealed_IsOperator
{
    class Book
    {
        static string libraryName = "Central Library";
        public readonly String ISBN;
        string title;
        string author;

        public Book(string title, string author, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine("\nBook Details");
            Console.WriteLine("Library Name : " + libraryName);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Author       : " + author);
            Console.WriteLine("ISBN         : " + ISBN);
        }
         public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + libraryName);
        }
    }
}