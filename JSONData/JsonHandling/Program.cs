using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        ////1. Create a JSON object for a Student with fields: name, age, and subjects (array).
        //Student student = new Student
        //{
        //    Name = "Sunakshi",
        //    Age = 21,
        //    Subjects = new string[] { "C#", "SQL", "ASP.NET" }
        //};
        //string json = JsonSerializer.Serialize(student);
        //Console.WriteLine(json);



        ////2. Convert a C# object (Car class) into JSON format.
        //Car car = new Car
        //{
        //    Brand = "Hyundai",
        //    Model = "Creta",
        //    Year = 2025
        //};
        //string json = JsonSerializer.Serialize(car);
        //Console.WriteLine(json);



        ////3. Read a JSON file and extract only specific fields (e.g., name, email).
        //string json = File.ReadAllText("users.json");
        //JsonDocument document = JsonDocument.Parse(json);
        //foreach (JsonElement user in document.RootElement.EnumerateArray())
        //{
        //    string name = user.GetProperty("name").GetString();
        //    string email = user.GetProperty("email").GetString();
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Email: {email}");
        //}



        ////4. Merge two JSON objects into one.
        //string json1 = @"{
        //    ""name"": ""Sunakshi"",
        //    ""age"": 21
        //}";
        //string json2 = @"{
        //    ""email"": ""sunakshi@gmail.com"",
        //    ""city"": ""Una""
        //}";
        //JsonObject obj1 = JsonNode.Parse(json1).AsObject();
        //JsonObject obj2 = JsonNode.Parse(json2).AsObject();
        //foreach (var property in obj2)
        //{
        //    obj1[property.Key] = property.Value.DeepClone();
        //}
        //Console.WriteLine(obj1);



        ////5. Validate JSON structure using Newtonsoft.Json.Schema.
        //string json = @"{
        //    'name': 'Sunakshi',
        //    'age': 21
        //}";
        //string schemaJson = @"{
        //    'type': 'object',
        //    'properties': {
        //        'name': { 'type': 'string' },
        //        'age': { 'type': 'integer' }
        //    },
        //    'required': ['name', 'age']
        //}";
        //JObject data = JObject.Parse(json);
        //JSchema schema = JSchema.Parse(schemaJson);
        //bool isValid = data.IsValid(schema);
        //Console.WriteLine($"Valid JSON: {isValid}");



        ////6.Convert a list of C# objects into a JSON array
        //List<Student> students = new List<Student>
        //{
        //    new Student { Name = "Aman", Age = 26 },
        //    new Student { Name = "Neha", Age = 22 },
        //    new Student { Name = "Rahul", Age = 28 }
        //};
        //string json = JsonSerializer.Serialize(
        //    students,
        //    new JsonSerializerOptions
        //    {
        //        WriteIndented = true
        //    });
        //Console.WriteLine(json);



        ////7. Parse JSON and filter records where age > 25
        string json = @"[
            { ""Name"": ""Aman"", ""Age"": 26 },
            { ""Name"": ""Neha"", ""Age"": 22 },
            { ""Name"": ""Rahul"", ""Age"": 30 },
            { ""Name"": ""Priya"", ""Age"": 24 }
        ]";
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(json);
        var result = students.Where(student => student.Age > 25);
        foreach (Student student in result)
        {
            Console.WriteLine($"{student.Name} - {student.Age}");
        }



        Console.ReadLine();

    }
}