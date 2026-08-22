using System;
using System.Reflection;
using System.Text;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Field)]
    class JsonField : Attribute
    {
        public string Name { get; set; }
    }

    class User1
    {
        [JsonField(Name = "user_name")]
        public string Username;
        [JsonField(Name = "user_age")]
        public int Age;
        [JsonField(Name = "user_email")]
        public string Email;
        public string Password;
    }

    class JsonSerializer
    {
        public static string Serialize(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public |
                BindingFlags.Instance);

            StringBuilder json = new StringBuilder();
            json.Append("{");
            bool firstField = true;
            foreach (FieldInfo field in fields)
            {
                JsonField? attribute = field.GetCustomAttribute<JsonField>();
                if (attribute != null)
                {
                    if (!firstField)
                    {
                        json.Append(",");
                    }
                    object? value = field.GetValue(obj);
                    json.Append($"\"{attribute.Name}\":");
                    if (value is string)
                    {
                        json.Append($"\"{value}\"");
                    }
                    else
                    {
                        json.Append(value);
                    }
                    firstField = false;
                }
            }
            json.Append("}");
            return json.ToString();
        }
    }
}