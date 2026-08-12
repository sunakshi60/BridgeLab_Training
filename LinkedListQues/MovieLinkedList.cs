using System;

namespace LinkedListQues
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int YearOfRelease;
        public double Rating;
        public Movie(string title, string director, int yearOfRelease, double rating)
        {
            Title = title;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
        }
        public void Display()
        {
            Console.WriteLine(
                $"Title: {Title}, Director: {Director}, Year: {YearOfRelease}, Rating: {Rating}"
            );
        }
    }


    public class MovieNode
    {
        public Movie Data;
        public MovieNode Next;
        public MovieNode Previous;

        public MovieNode(Movie data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }


    public class MovieLinkedList
    {
        private MovieNode head;
        private MovieNode tail;
        public void AddAtBeginning(Movie movie)
        {
            MovieNode newNode = new MovieNode(movie);

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
            Console.WriteLine("Movie added at beginning.");
        }

        public void AddAtEnd(Movie movie)
        {
            MovieNode newNode = new MovieNode(movie);
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
            Console.WriteLine("Movie added at end.");
        }
        public void AddAtPosition(Movie movie, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(movie);
                return;
            }
            MovieNode current = head;
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
                AddAtEnd(movie);
                return;
            }
            MovieNode newNode = new MovieNode(movie);
            newNode.Next = current.Next;
            newNode.Previous = current;
            current.Next.Previous = newNode;
            current.Next = newNode;
            Console.WriteLine($"Movie added at position {position}.");
        }

        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("Movie list is empty.");
                return;
            }
            MovieNode current = head;
            while (current != null)
            {
                if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current == head)
                    {
                        head = current.Next;

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
                        tail = current.Previous;
                        tail.Next = null;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    Console.WriteLine("Movie removed successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Movie not found.");
        }

        public void SearchByDirector(string director)
        {
            MovieNode current = head;
            bool found = false;
            while (current != null)
            {
                if (current.Data.Director.Equals(
                    director,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
            {
                Console.WriteLine("No movie found for this director.");
            }
        }
        public void SearchByRating(double rating)
        {
            MovieNode current = head;
            bool found = false;
            while (current != null)
            {
                if (current.Data.Rating == rating)
                {
                    current.Data.Display();
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
            {
                Console.WriteLine("No movie found with this rating.");
            }
        }
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Movie list is empty.");
                return;
            }
            MovieNode current = head;
            Console.WriteLine("\n----- Movies (Forward) -----");
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
                Console.WriteLine("Movie list is empty.");
                return;
            }
            MovieNode current = tail;
            Console.WriteLine("\n----- Movies (Reverse) -----");
            while (current != null)
            {
                current.Data.Display();
                current = current.Previous;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            MovieNode current = head;
            while (current != null)
            {
                if (current.Data.Title.Equals(
                    title,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Rating = newRating;
                    Console.WriteLine("Movie rating updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Movie not found.");
        }
    }
}