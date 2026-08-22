class Student1
{
	public string Name { get; set; }

	public Student1()
	{
		Name = "Unknown";
	}

	public void Display()
	{
		Console.WriteLine($"Student Name: {Name}");
	}
}