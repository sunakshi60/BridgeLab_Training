using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class Inject : Attribute
{
}

class UserRepository
{
    public void GetUser()
    {
        Console.WriteLine("User retrieved from database.");
    }
}

class UserService
{
    [Inject]
    private UserRepository repository;

    public void DisplayUser()
    {
        repository.GetUser();
    }
}

class DIContainer
{
    private Dictionary<Type, object> services = new Dictionary<Type, object>();

    public void Register<T>()
    {
        services[typeof(T)] =Activator.CreateInstance(typeof(T))!;
    }

    public T Resolve<T>()
    {
        Type type = typeof(T);
        T obj = (T)Activator.CreateInstance(type)!;

        FieldInfo[] fields = type.GetFields(
            BindingFlags.NonPublic |
            BindingFlags.Public |
            BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            Inject? attribute =field.GetCustomAttribute<Inject>();
            if (attribute != null && services.ContainsKey(field.FieldType))
            {
                field.SetValue(obj,services[field.FieldType]);
            }
        }

        return obj;
    }
}