using System;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class Todo : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public Todo(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    class Project
    {
        [Todo("Implement login validation", "Rahul", "HIGH")]
        public void Login()
        {
            Console.WriteLine("Login method.");
        }

        [Todo("Add payment gateway", "Aman")]
        public void Payment()
        {
            Console.WriteLine("Payment method.");
        }

        [Todo("Create dashboard UI", "Priya", "LOW")]
        [Todo("Add charts to dashboard", "Rohit", "MEDIUM")]
        public void Dashboard()
        {
            Console.WriteLine("Dashboard method.");
        }
    }
}