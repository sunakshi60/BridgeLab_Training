using System;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method)]
    class RoleAllowed : Attribute
    {
        public string Role { get; }

        public RoleAllowed(string role)
        {
            Role = role;
        }
    }

    class AdminOperations
    {
        [RoleAllowed("ADMIN")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully.");
        }

        [RoleAllowed("ADMIN")]
        public void ViewAdminPanel()
        {
            Console.WriteLine("Welcome to Admin Panel.");
        }

        public void ViewProfile()
        {
            Console.WriteLine("Profile viewed.");
        }
    }
}