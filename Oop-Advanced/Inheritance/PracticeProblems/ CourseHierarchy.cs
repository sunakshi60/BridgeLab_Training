using System;

namespace PracticeProblems
{
	class Course
	{
		private string CourseName;
		private int Duration;

		public Course(string courseName, int duration)
		{
			CourseName = courseName;
			Duration = duration;
		}

		public virtual void DisplayCourseDetails()
		{
			Console.WriteLine($"Course Name : {CourseName}");
			Console.WriteLine($"Duration : {Duration} Months");
		}
	}

	class OnlineCourse : Course
	{
		public string Platform;
		public bool IsRecorded;

		public OnlineCourse(string courseName, int duration,string platform, bool isRecorded): base(courseName, duration)
		{
			Platform = platform;
			IsRecorded = isRecorded;
		}
		public override void DisplayCourseDetails()
		{
			base.DisplayCourseDetails();
			Console.WriteLine($"Platform : {Platform}");
			Console.WriteLine($"Recorded : {IsRecorded}");
		}
	}

	class PaidOnlineCourse : OnlineCourse
	{
		public double Fee;
		public double Discount;

		public PaidOnlineCourse(string courseName, int duration,string platform, bool isRecorded,double fee, double discount) : base(courseName, duration, platform, isRecorded)
		{
			Fee = fee;
			Discount = discount;
		}

		public override void DisplayCourseDetails()
		{
			base.DisplayCourseDetails();
			Console.WriteLine($"Fee : {Fee} Rupees");
			Console.WriteLine($"Discount : {Discount}%");

			double finalFee = Fee - (Fee * Discount / 100);
			Console.WriteLine($"Final Fee : {finalFee} Rupees");
		}
	}
}