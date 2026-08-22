using System;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfo : Attribute
    {
        public string Priority { get; }
        public string AssignedTo { get; }

        public TaskInfo(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager
    {
        [TaskInfo("High", "Sunakshi")]
        public void CompleteTask()
        {
            Console.WriteLine("Task is being completed.");
        }
    }
}