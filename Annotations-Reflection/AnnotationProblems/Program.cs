using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace AnnotationProblems
{
    class Program
    {
        static void Main()
        {
            //Dog dog = new Dog();
            //dog.MakeSound();

            //LegacyAPI api = new LegacyAPI();
            //api.OldFeature();
            //api.NewFeature();

            //NonGenericCollection collection = new NonGenericCollection();
            //collection.AddItems();

            //TaskManager manager = new TaskManager();
            //manager.CompleteTask();
            //MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
            //TaskInfo? attribute = method?.GetCustomAttribute<TaskInfo>();
            //if (attribute != null)
            //{
            //    Console.WriteLine($"Priority: {attribute.Priority}");
            //    Console.WriteLine($"Assigned To: {attribute.AssignedTo}");
            //}


            //BugTracker tracker = new BugTracker();
            //tracker.Login();
            //MethodInfo? method = typeof(BugTracker).GetMethod("Login");
            //if (method != null)
            //{
            //    BugReport[] reports = method.GetCustomAttributes<BugReport>().ToArray();
            //    Console.WriteLine("\nBug Reports:");
            //    foreach (BugReport report in reports)
            //    {
            //        Console.WriteLine($"- {report.Description}");
            //    }
            //}


            //Type type = typeof(TaskManager1);
            //MethodInfo[] methods = type.GetMethods(
            //    BindingFlags.Public |
            //    BindingFlags.Instance |
            //    BindingFlags.DeclaredOnly);
            //Console.WriteLine("Important Methods:");
            //foreach (MethodInfo method in methods)
            //{
            //    ImportantMethod? attribute = method.GetCustomAttribute<ImportantMethod>();
            //    if (attribute != null)
            //    {
            //        Console.WriteLine(
            //            $"Method: {method.Name}, Level: {attribute.Level}");
            //    }
            //}


            //Type type = typeof(Project);
            //MethodInfo[] methods = type.GetMethods(
            //    BindingFlags.Public |
            //    BindingFlags.Instance |
            //    BindingFlags.DeclaredOnly);
            //Console.WriteLine("Pending Tasks:");
            //foreach (MethodInfo method in methods)
            //{
            //    Todo[] todos = method.GetCustomAttributes<Todo>().ToArray();
            //    foreach (Todo todo in todos)
            //    {
            //        Console.WriteLine($"Method: {method.Name}");
            //        Console.WriteLine($"Task: {todo.Task}");
            //        Console.WriteLine($"Assigned To: {todo.AssignedTo}");
            //        Console.WriteLine($"Priority: {todo.Priority}");
            //        Console.WriteLine("-------------------------");
            //    }
            //}


            //Type type = typeof(PerformanceTest);
            //PerformanceTest obj = new PerformanceTest();
            //MethodInfo[] methods = type.GetMethods(
            //    BindingFlags.Public |
            //    BindingFlags.Instance |
            //    BindingFlags.DeclaredOnly);
            //foreach (MethodInfo method in methods)
            //{
            //    LogExecutionTime? attribute = method.GetCustomAttribute<LogExecutionTime>();
            //    if (attribute != null)
            //    {
            //        Stopwatch stopwatch = Stopwatch.StartNew();
            //        method.Invoke(obj, null);
            //        stopwatch.Stop();
            //        Console.WriteLine($"{method.Name} execution time: {stopwatch.ElapsedMilliseconds} ms");
            //    }
            //}


            //try
            //{
            //    User user1 = new User("Sunakshi");
            //    Console.WriteLine($"Username: {user1.Username}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    User user2 = new User("Sunakshi1234");
            //    Console.WriteLine($"Username: {user2.Username}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //AdminOperations operations = new AdminOperations();
            //string currentUserRole = "USER";
            //Console.WriteLine($"Current Role: {currentUserRole}");
            //Console.WriteLine();
            //ExecuteMethod(operations, "DeleteUser", currentUserRole);
            //Console.WriteLine();
            //currentUserRole = "ADMIN";
            //Console.WriteLine($"Current Role: {currentUserRole}");
            //Console.WriteLine();
            //ExecuteMethod(operations, "DeleteUser", currentUserRole);


            //User1 user = new User1
            //{
            //    Username = "Sunakshi",
            //    Age = 21,
            //    Email = "sunakshi@example.com",
            //    Password = "12345"
            //};
            //string json = JsonSerializer.Serialize(user);
            //Console.WriteLine("Serialized JSON:");
            //Console.WriteLine(json);


            Calculator calculator = new Calculator();
            CacheManager cacheManager = new CacheManager();
            Console.WriteLine("First Call:");
            object result1 = cacheManager.Execute(calculator, "Calculate", 100000);
            Console.WriteLine($"Result: {result1}");
            Console.WriteLine();
            Console.WriteLine("Second Call:");
            object result2 = cacheManager.Execute(calculator, "Calculate", 100000);
            Console.WriteLine($"Result: {result2}");
            Console.WriteLine();
            Console.WriteLine("Third Call with different input:");
            object result3 = cacheManager.Execute(calculator, "Calculate", 50000);
            Console.WriteLine($"Result: {result3}");



            Console.ReadLine();
        }
        //static void ExecuteMethod(object obj,string methodName,string currentUserRole)
        //{
        //    MethodInfo? method = obj.GetType().GetMethod(methodName);
        //    if (method == null)
        //    {
        //        Console.WriteLine("Method not found.");
        //        return;
        //    }
        //    RoleAllowed? attribute = method.GetCustomAttribute<RoleAllowed>();
        //    if (attribute != null)
        //    {
        //        if (attribute.Role != currentUserRole)
        //        {
        //            Console.WriteLine("Access Denied!");
        //            return;
        //        }
        //    }

        //    method.Invoke(obj, null);
        //}
    }
}