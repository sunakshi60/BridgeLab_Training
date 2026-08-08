using System;
using System.Collections.Generic;

namespace AssignmentQuestion
{
    public abstract class CourseType
    {
        public string EvalautionType;

        public CourseType(string evaluationType)
        {
            EvalautionType = evaluationType;
        }
        public abstract void DisplayEvaluation();
    }

    public class ExamCourse : CourseType
    {
        public int ExamDuration;

        public ExamCourse(string evaluationType,int examDuration) : base(evaluationType)
        {
            ExamDuration = examDuration;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine($"Evaluation: {EvalautionType}, " + $"Exam Duration: {ExamDuration} hours");
        }
    }

    public class AssignmentCourse : CourseType
    {
        public int NumberOfAssignments;

        public AssignmentCourse(string evaluationType, int numberOfAssignments) : base(evaluationType)
        {
            NumberOfAssignments = numberOfAssignments;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine($"Evaluation: {EvalautionType}, " + $"Number of Assignments: {NumberOfAssignments}");
        }
    }

    public class Course<T> where T : CourseType
    {
        public int CourseId;
        public string CourseName;
        public string Department;
        public T Evaluation;

        public Course(int courseId, string courseName, string department, T evaluation) 
        { 
            CourseId = courseId; 
            CourseName = courseName; 
            Department = department;
            Evaluation = evaluation;
        }

        public void DisplayCourse() 
        { 
            Console.WriteLine($"Course ID: {CourseId}, " + $"Course Name: {CourseName}, " + $"Department: {Department}"); Evaluation.DisplayEvaluation(); 
        }
    }
    public class Question3
    {
        public static void Run()
        {
            Console.WriteLine("\n===== UNIVERSITY COURSE MANAGEMENT SYSTEM =====\n");
            Course<ExamCourse> programming = new Course<ExamCourse>(101, "C# Programming", "Computer Science", new ExamCourse("Final Examination", 3));
            Course<AssignmentCourse> database = new Course<AssignmentCourse>(102, "Database Management", "Computer Science", new AssignmentCourse("Assignments", 5));

            Console.WriteLine("--- Course 1 ---"); 
            programming.DisplayCourse(); 

            Console.WriteLine("\n--- Course 2 ---"); 
            database.DisplayCourse();

            Console.WriteLine("\n--- Course List ---");

            List<CourseType> evaluationTypes = new List<CourseType>();
            evaluationTypes.Add(new ExamCourse("Mid Term Exam", 2));
            evaluationTypes.Add(new AssignmentCourse("Weekly Assignments", 4));
            foreach (CourseType evaluation in evaluationTypes) 
            { 
                evaluation.DisplayEvaluation();
            }
        }
    }
}