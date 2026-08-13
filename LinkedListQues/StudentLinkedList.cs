using System;

namespace LinkedListQues
{
	public class Student
	{
		public int RollNumber;
		public string Name;
		public int Age;
		public char Grade;

		public Student(int rollNumber, string name, int age, char grade)
		{
			RollNumber = rollNumber;
			Name = name;
			Age = age;
			Grade = grade;
		}

		public void Display()
		{
			Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}");
		}
	}

	public class StudentNode
	{
		public Student Data;
		public StudentNode Next;

		public StudentNode(Student data)
		{
			Data = data;
			Next = null;
		}
	}

	public class StudentLinkedList
	{
		private StudentNode head;
		public void AddAtBeginning(Student student)
		{
			StudentNode newNode = new StudentNode(student);
			newNode.Next = head;
			head = newNode;

			Console.WriteLine("Student added at beginning.");
		}


		public void AddAtEnd(Student student)
		{
			StudentNode newNode = new StudentNode(student);

			if (head == null)
			{
				head = newNode;
				Console.WriteLine("Student added at end.");
				return;
			}
			StudentNode current = head;
			while (current.Next != null)
			{
				current = current.Next;
			}
			current.Next = newNode;
			Console.WriteLine("Student added at end.");
		}


		public void AddAtPosition(Student student, int position)
		{
			if (position < 1)
			{
				Console.WriteLine("Invalid position.");
				return;
			}
			if (position == 1)
			{
				AddAtBeginning(student);
				return;
			}
			if (head == null)
			{
				Console.WriteLine("Position out of range.");
				return;
			}
			StudentNode newNode = new StudentNode(student);
			StudentNode current = head;
			for (int i = 1; i < position - 1 && current != null; i++)
			{
				current = current.Next;
			}

			if (current == null)
			{
				Console.WriteLine("Position out of range.");
				return;
			}
			newNode.Next = current.Next;
			current.Next = newNode;
			Console.WriteLine($"Student added at position {position}.");
		}
		public void DeleteByRollNumber(int rollNumber)
		{
			if (head == null)
			{
				Console.WriteLine("List is empty.");
				return;
			}
			if (head.Data.RollNumber == rollNumber)
			{
				head = head.Next;

				Console.WriteLine("Student deleted successfully.");
				return;
			}
			StudentNode current = head;
			while (current.Next != null)
			{
				if (current.Next.Data.RollNumber == rollNumber)
				{
					current.Next = current.Next.Next;

					Console.WriteLine("Student deleted successfully.");
					return;
				}
				current = current.Next;
			}
			Console.WriteLine("Student not found.");
		}

		public Student SearchByRollNumber(int rollNumber)
		{
			StudentNode current = head;
			while (current != null)
			{
				if (current.Data.RollNumber == rollNumber)
				{
					return current.Data;
				}
				current = current.Next;
			}
			return null;
		}

		public void UpdateGrade(int rollNumber, char newGrade)
		{
			StudentNode current = head;
			while (current != null)
			{
				if (current.Data.RollNumber == rollNumber)
				{
					current.Data.Grade = newGrade;

					Console.WriteLine("Grade updated successfully.");
					return;
				}
				current = current.Next;
			}
			Console.WriteLine("Student not found.");
		}

		public void DisplayAll()
		{
			if (head == null)
			{
				Console.WriteLine("No student records found.");
				return;
			}
			StudentNode current = head;
			Console.WriteLine("\n----- Student Records -----");
			while (current != null)
			{
				current.Data.Display();
				current = current.Next;
			}
		}
	}
}