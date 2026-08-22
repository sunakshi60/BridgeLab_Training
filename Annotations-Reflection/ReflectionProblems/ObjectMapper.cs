using System;
using System.Collections.Generic;
using System.Reflection;

public class Student2
{
    public string Name;
    public int Age;
    public string Course;
}

class ObjectMapper
{
    public static T ToObject<T>(Type clazz,Dictionary<string, object> properties)
    {
        T obj = (T)Activator.CreateInstance(clazz)!;
        foreach (var property in properties)
        {
            FieldInfo? field = clazz.GetField(property.Key);
            if (field != null)
            {
                field.SetValue(obj, property.Value);
            }
        }
        return obj;
    }
}