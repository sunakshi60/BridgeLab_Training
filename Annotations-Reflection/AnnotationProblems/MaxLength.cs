using System;
using System.Reflection;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Field)]
    class MaxLength : Attribute
    {
        public int Value { get; }

        public MaxLength(int value)
        {
            Value = value;
        }
    }

    class User
    {
        [MaxLength(10)]
        public string Username;

        public User(string username)
        {
            FieldInfo? field = typeof(User).GetField("Username");

            MaxLength? attribute =
                field?.GetCustomAttribute<MaxLength>();

            if (attribute != null && username.Length > attribute.Value)
            {
                throw new ArgumentException(
                    $"Username cannot exceed {attribute.Value} characters.");
            }

            Username = username;
        }
    }
}