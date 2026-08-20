using System;

namespace PracticeProblems
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
    public class AgeValidator
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }

            Console.WriteLine("Access granted!");
        }
    }
}