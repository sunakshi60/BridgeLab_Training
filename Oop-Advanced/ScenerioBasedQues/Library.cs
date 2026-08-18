using System;

namespace ScenerioBasedQues
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Status;

        public Book(string title, string author, string status)
        {
            Title = title;
            Author = author;
            Status = status;
        }
    }

    public class Library
    {
        private Book[] books;

        public Library(Book[] books)
        {
            this.books = books;
        }

        public void SearchBook(string searchTitle)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Status: {book.Status}");
                    Console.WriteLine();

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(
                    $"Title: {book.Title}, Author: {book.Author}, Status: {book.Status}"
                );
            }
        }

        public void UpdateBookStatus(string title, string newStatus)
        {
            foreach (Book book in books)
            {
                if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    book.Status = newStatus;
                    Console.WriteLine("Book status updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }
    }
}