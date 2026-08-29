using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        //1. Read a JSON file and print all keys and values.
        //string json = File.ReadAllText("users.json");
        //using JsonDocument document = JsonDocument.Parse(json);
        //foreach (JsonElement user in document.RootElement.EnumerateArray())
        //{
        //    foreach (JsonProperty property in user.EnumerateObject())
        //    {
        //        Console.WriteLine($"{property.Name}: {property.Value}");
        //    }
        //    Console.WriteLine();
        //}



        //2. Convert a list of C# objects into a JSON array.
        //List<Student> students = new List<Student>
        //{
        //    new Student { Name = "Aman", Age = 22 },
        //    new Student { Name = "Neha", Age = 24 },
        //    new Student { Name = "Rahul", Age = 26 }
        //};
        //string json = JsonSerializer.Serialize(
        //    students,
        //    new JsonSerializerOptions
        //    {
        //        WriteIndented = true
        //    });
        //Console.WriteLine(json);



        //3. Filter JSON data: Print only users older than 25 years.
        string json = @"[
            { ""Name"": ""Aman"", ""Age"": 28 },
            { ""Name"": ""Neha"", ""Age"": 24 },
            { ""Name"": ""Rahul"", ""Age"": 30 },
            { ""Name"": ""Priya"", ""Age"": 22 }
        ]";
        List<User> users = JsonSerializer.Deserialize<List<User>>(json);
        var result = users.Where(user => user.Age > 25);
        foreach (User user in result)
        {
            Console.WriteLine($"{user.Name} - {user.Age}");
        }


        Console.ReadLine();
    }
}