using System;
using System.Collections.Generic;

namespace AssignmentQuestion
{
    public abstract class JobRole
    {
        public string RoleName;

        public JobRole(string roleName) 
        {
            RoleName = roleName; 
        }

        public abstract void DisplayRole();
    }

    public class SoftwareEngineer : JobRole
    {
        public string ProgrammingLanguage;

        public SoftwareEngineer(string roleName, string programmingLanguage) : base(roleName) 
        { 
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayRole()
        { 
            Console.WriteLine($"Role: {RoleName}, " + $"Skill: {ProgrammingLanguage}"); 
        }
    }

    public class DataScientist : JobRole
    {
        public string Specialization;

        public DataScientist(string roleName, string specialization) : base(roleName) 
        { 
            Specialization = specialization; 
        }
        public override void DisplayRole() 
        { 
            Console.WriteLine($"Role: {RoleName}, " + $"Specialization: {Specialization}");
        }
    }

    public class Resume<T> where T : JobRole
    {
        public string CandidateName;
        public string Email;
        public T JobRole;
        public Resume(string candidateName, string email, T jobRole)
        { 
            CandidateName = candidateName;
            Email = email; 
            JobRole = jobRole;
        }
        public void DisplayResume()
        { 
            Console.WriteLine($"Candidate: {CandidateName}, " + $"Email: {Email}"); JobRole.DisplayRole(); 
        }
    }

    public class ResumeScreening
    { 
        public static void ScreenResume<T>(Resume<T> resume)
            where T : JobRole 
        { 
            Console.WriteLine( $"Resume Screening for {resume.CandidateName}"); 
            resume.DisplayResume(); 
            Console.WriteLine("Status: Resume Processed"); 
        } 
    }
    public class Question5
    {
        public static void Run()
        {
            Console.WriteLine("\n===== AI-DRIVEN RESUME SCREENING SYSTEM =====\n");
            Resume<SoftwareEngineer> softwareResume = new Resume<SoftwareEngineer>("Rahul", "rahul@gmail.com", new SoftwareEngineer("Software Engineer", "C#"));
            Resume<DataScientist> dataResume = new Resume<DataScientist>("Priya", "priya@gmail.com", new DataScientist("Data Scientist", "Machine Learning"));
            Console.WriteLine("--- Candidate Resumes ---"); 
            softwareResume.DisplayResume(); 
            Console.WriteLine(); 
            dataResume.DisplayResume();

            Console.WriteLine("\n--- Resume Screening ---"); 
            ResumeScreening.ScreenResume(softwareResume);
            ResumeScreening.ScreenResume(dataResume);

            Console.WriteLine("\n--- Screening Pipeline ---"); 
            List<JobRole> screeningPipeline = new List<JobRole>(); 
            screeningPipeline.Add(new SoftwareEngineer("Software Engineer", "Java")); screeningPipeline.Add(new DataScientist("Data Scientist", "Python"));
            foreach (JobRole role in screeningPipeline) 
            { 
                role.DisplayRole();
            }
        }
    }
 }