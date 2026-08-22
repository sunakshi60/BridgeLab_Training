using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ReflectionProblems
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Enter class name: ");
            //string? className = Console.ReadLine();
            //Type? type = Assembly.GetExecutingAssembly()
            //                    .GetTypes()
            //                    .FirstOrDefault(t => t.Name == className); if (type == null)
            //{
            //    Console.WriteLine("Class not found.");
            //    return;
            //}
            //Console.WriteLine("\nMethods:");
            //foreach (MethodInfo method in type.GetMethods())
            //{
            //    Console.WriteLine(method.Name);
            //}
            //Console.WriteLine("\nFields:");
            //foreach (FieldInfo field in type.GetFields(
            //    BindingFlags.Public |
            //    BindingFlags.NonPublic |
            //    BindingFlags.Instance))
            //{
            //    Console.WriteLine(field.Name);
            //}
            //Console.WriteLine("\nConstructors:");
            //foreach (ConstructorInfo constructor in type.GetConstructors(
            //    BindingFlags.Public |
            //    BindingFlags.NonPublic |
            //    BindingFlags.Instance))
            //{
            //    Console.WriteLine(constructor);
            //}


            //Person person = new Person();
            //Type type = typeof(Person);
            //FieldInfo? field = type.GetField(
            //    "age",
            //    BindingFlags.NonPublic |
            //    BindingFlags.Instance);
            //if (field != null)
            //{
            //    Console.WriteLine($"Original Age: {field.GetValue(person)}");
            //    field.SetValue(person, 25);
            //    Console.WriteLine($"Updated Age: {field.GetValue(person)}");
            //}


            //Calculator calculator = new Calculator();
            //Type type = typeof(Calculator);
            //MethodInfo? method = type.GetMethod(
            //    "Multiply",
            //    BindingFlags.NonPublic |
            //    BindingFlags.Instance);
            //if (method != null)
            //{
            //    object? result = method.Invoke(calculator,new object[] { 10, 5 });
            //    Console.WriteLine($"Result: {result}");
            //}


            //Type type = typeof(Student1);
            //object? obj = Activator.CreateInstance(type);
            //Student1 student = (Student1)obj!;
            //student.Name = "Sunakshi";
            //student.Display();


            //MathOperations math = new MathOperations();
            //Console.Write("Enter method name (Add/Subtract/Multiply): ");
            //string? methodName = Console.ReadLine();
            //Console.Write("Enter first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //MethodInfo? method = typeof(MathOperations).GetMethod(methodName!);
            //if (method == null)
            //{
            //    Console.WriteLine("Method not found.");
            //    return;
            //}
            //object? result = method.Invoke(
            //    math,
            //    new object[] { a, b });
            //Console.WriteLine($"Result: {result}");


            //Type type = typeof(Book);
            //Author? author = type.GetCustomAttribute<Author>();
            //if (author != null)
            //{
            //    Console.WriteLine($"Author: {author.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Author attribute not found.");
            //}


            //Type type = typeof(Configuration);
            //FieldInfo? field = type.GetField(
            //    "API_KEY",
            //    BindingFlags.NonPublic |
            //    BindingFlags.Static);
            //if (field != null)
            //{
            //    Console.WriteLine($"Original API Key: {field.GetValue(null)}");
            //    field.SetValue(null, "NEW-API-KEY-123");
            //    Console.WriteLine($"Updated API Key: {field.GetValue(null)}");
            //}


            //    Dictionary<string, object> properties = new Dictionary<string, object>
            //{
            //    { "Name", "Sunakshi" },
            //    { "Age", 21 },
            //    { "Course", "Computer Science" }
            //};
            //    Student2 student =ObjectMapper.ToObject<Student2>(typeof(Student2), properties);
            //    Console.WriteLine($"Name: {student.Name}");
            //    Console.WriteLine($"Age: {student.Age}");
            //    Console.WriteLine($"Course: {student.Course}");



            //Employee employee = new Employee
            //{
            //    Name = "Sunakshi",
            //    Age = 21,
            //    Department = "Software"
            //};
            //string json = JsonGenerator.ToJson(employee);
            //Console.WriteLine(json);


            //IGreeting greeting =
            //DispatchProxy.Create<IGreeting, LoggingProxy>();
            //LoggingProxy proxy = (LoggingProxy)greeting;
            //proxy.SetTarget(new Greeting());
            //greeting.SayHello("Sunakshi");


            //DIContainer container = new DIContainer();
            //container.Register<UserRepository>();
            //UserService service = container.Resolve<UserService>();
            //service.DisplayUser();


            PerformanceTest obj = new PerformanceTest();
            Type type = typeof(PerformanceTest);
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly);
            foreach (MethodInfo method in methods)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(obj, null);
                stopwatch.Stop();
                Console.WriteLine($"{method.Name}: " + $"{stopwatch.ElapsedMilliseconds} ms");
            }


            Console.ReadKey();
        }
    }
}