using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Xml.Linq;

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
        //string json = @"[
        //    { ""Name"": ""Aman"", ""Age"": 28 },
        //    { ""Name"": ""Neha"", ""Age"": 24 },
        //    { ""Name"": ""Rahul"", ""Age"": 30 },
        //    { ""Name"": ""Priya"", ""Age"": 22 }
        //]";
        //List<User> users = JsonSerializer.Deserialize<List<User>>(json);
        //var result = users.Where(user => user.Age > 25);
        //foreach (User user in result)
        //{
        //    Console.WriteLine($"{user.Name} - {user.Age}");
        //}



        //4. Validate an email field using JSON Schema.
        //string json = @"{
        //    'name': 'Sunakshi',
        //    'email': 'sunakshi@gmail.com'
        //}";
        //string schemaJson = @"{
        //    'type': 'object',
        //    'properties': {
        //        'name': {
        //            'type': 'string'
        //        },
        //        'email': {
        //            'type': 'string',
        //            'format': 'email'
        //        }
        //    },
        //    'required': ['name', 'email']
        //}";
        //JObject data = JObject.Parse(json);
        //JSchema schema = JSchema.Parse(schemaJson);
        //bool isValid = data.IsValid(schema);
        //Console.WriteLine($"Valid JSON: {isValid}");



        //5. Merge two JSON files into a single JSON object.
        //string json1 = File.ReadAllText("user.json");
        //string json2 = File.ReadAllText("contact.json");
        //JObject obj1 = JObject.Parse(json1);
        //JObject obj2 = JObject.Parse(json2);
        //obj1.Merge(obj2);
        //Console.WriteLine(obj1);



        //6. Convert JSON to XML format.
        //string json = @"{
        //    ""name"": ""Sunakshi"",
        //    ""age"": 21,
        //    ""city"": ""Una""
        //}";
        //using JsonDocument document = JsonDocument.Parse(json);
        //JsonElement root = document.RootElement;
        //XElement xml = new XElement("Student");
        //foreach (JsonProperty property in root.EnumerateObject())
        //{
        //    xml.Add(
        //        new XElement(
        //            property.Name,
        //            property.Value.ToString()
        //        )
        //    );
        //}
        //Console.WriteLine(xml);



        //7. Convert CSV data into JSON.
        //string[] lines = File.ReadAllLines("students.csv");
        //List<Student> students = new List<Student>();
        //for (int i = 1; i < lines.Length; i++)
        //{
        //    string[] data = lines[i].Split(',');
        //    Student student = new Student
        //    {
        //        Name = data[0],
        //        Age = int.Parse(data[1]),
        //        City = data[2]
        //    };
        //    students.Add(student);
        //}
        //string json = JsonSerializer.Serialize(
        //    students,
        //    new JsonSerializerOptions
        //    {
        //        WriteIndented = true
        //    });
        //Console.WriteLine(json);



        //8. Generate a JSON report from database records.
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Aman",
                Department = "IT",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Neha",
                Department = "HR",
                Salary = 45000
            },
            new Employee
            {
                Id = 3,
                Name = "Rahul",
                Department = "IT",
                Salary = 60000
            }
        };
        string jsonReport = JsonSerializer.Serialize(
            employees,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });
        File.WriteAllText("EmployeeReport.json", jsonReport);
        Console.WriteLine("JSON report generated successfully.");





        Console.ReadLine();
    }
}