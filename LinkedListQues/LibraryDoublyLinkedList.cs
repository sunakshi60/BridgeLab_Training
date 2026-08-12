using System;

namespace LinkedLinkQues
{
    public class Book
    {
        public int BookId;
        public string BookTitle;
        public string Author;
        public string Genre;
        public bool IsAvailable;

        public Book(int bookId,string bookTitle,string author,string genre,bool isAvailable)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
        }

        public void Display()
        {
            string status = IsAvailable ? "Available" : "Not Available";
            Console.WriteLine($"Book ID: {BookId}, " + $"Title: {BookTitle}, " +$"Author: {Author}, " + $"Genre: {Genre}, " +$"Status: {status}"
            );
        }
    }

    public class BookNode
    {
        public Book Data;
        public BookNode Next;
        public BookNode Previous;

        public BookNode(Book data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class LibraryDoublyLinkedList
    {
        private BookNode head;
        private BookNode tail;
        public void AddAtBeginning(Book book)
        {
            BookNode newNode = new BookNode(book);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Console.WriteLine("Book added at beginning.");
        }

        public void AddAtEnd(Book book)
        {
            BookNode newNode = new BookNode(book);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            Console.WriteLine("Book added at end.");
        }


        public void AddAtPosition(Book book, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            if (position == 1)
            {
                AddAtBeginning(book);
                return;
            }

            BookNode current = head;

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            if (current.Next == null)
            {
                AddAtEnd(book);
                return;
            }

            BookNode newNode = new BookNode(book);

            newNode.Next = current.Next;
            newNode.Previous = current;

            current.Next.Previous = newNode;
            current.Next = newNode;

            Console.WriteLine($"Book added at position {position}.");
        }

        public void RemoveByBookId(int bookId)
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = head;

            while (current != null)
            {
                if (current.Data.BookId == bookId)
                {
                    if (current == head)
                    {
                        head = head.Next;

                        if (head != null)
                        {
                            head.Previous = null;
                        }
                        else
                        {
                            tail = null;
                        }
                    }

                    else if (current == tail)
                    {
                        tail = tail.Previous;
                        tail.Next = null;
                    }

                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }

                    Console.WriteLine("Book removed successfully.");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public void SearchByTitle(string title)
        {
            BookNode current = head;
            bool found = false;

            while (current != null)
            {
                if (current.Data.BookTitle.Equals(
                    title,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }

                current = current.Next;
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchByAuthor(string author)
        {
            BookNode current = head;
            bool found = false;

            while (current != null)
            {
                if (current.Data.Author.Equals(
                    author,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }

                current = current.Next;
            }

            if (!found)
            {
                Console.WriteLine("No book found by this author.");
            }
        }

        public void UpdateAvailability(int bookId, bool isAvailable)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.Data.BookId == bookId)
                {
                    current.Data.IsAvailable = isAvailable;

                    Console.WriteLine(
                        "Book availability updated successfully."
                    );

                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = head;

            Console.WriteLine("\n----- Books (Forward) -----");

            while (current != null)
            {
                current.Data.Display();
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = tail;

            Console.WriteLine("\n----- Books (Reverse) -----");

            while (current != null)
            {
                current.Data.Display();
                current = current.Previous;
            }
        }

        public int CountBooks()
        {
            int count = 0;

            BookNode current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public void DisplayBookCount()
        {
            Console.WriteLine(
                $"Total number of books: {CountBooks()}"
            );
        }
    }
}