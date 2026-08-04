using System;

namespace PracticeProblems
{
    class Book
    {
        public string Title;
        public int PublicationYear;

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Publication Year : {PublicationYear}");
        }
    }

    class Author : Book
    {
        public string Name;
        public string Bio;

        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author Name : {Name}");
            Console.WriteLine($"Bio : {Bio}");
        }
    }


}