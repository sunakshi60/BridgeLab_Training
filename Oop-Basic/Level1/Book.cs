using System;

namespace Level1
{
	class Book
	{
		private string title;
		private string author;
		private int price;

		public Book(string title, string author, int price) 
		{
			this.title = title;
			this.author = author;
			this.price = price;
		}

		public void DisplayBookDetails() 
		{
			Console.WriteLine("Book Title: " + title);
			Console.WriteLine("Author: " + author);
			Console.WriteLine("Price: " + price);
		}
	}

}