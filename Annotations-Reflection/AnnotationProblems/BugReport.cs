using System;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReport : Attribute
    {
        public string Description { get; }

        public BugReport(string description)
        {
            Description = description;
        }
    }

    class BugTracker
    {
        [BugReport("Login button is not working.")]
        [BugReport("Error message is not displayed correctly.")]
        public void Login()
        {
            Console.WriteLine("Login method executed.");
        }
    }
}