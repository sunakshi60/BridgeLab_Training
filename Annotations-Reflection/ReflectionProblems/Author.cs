using System;

[AttributeUsage(AttributeTargets.Class)]
class Author : Attribute
{
    public string Name { get; }

    public Author(string name)
    {
        Name = name;
    }
}

[Author("Sunakshi")]
class Book
{
    public void Display()
    {
        Console.WriteLine("Book information.");
    }
}