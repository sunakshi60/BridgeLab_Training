using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method)]
    class CacheResult : Attribute
    {
    }

    class Calculator
    {
        [CacheResult]
        public long Calculate(int number)
        {
            Console.WriteLine("Calculating...");
            Thread.Sleep(2000);
            long result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += (long)i * i;
            }
            return result;
        }
    }

    class CacheManager
    {
       private Dictionary<string, object> cache = new Dictionary<string, object>();
        public object Execute(object obj, string methodName, int input)
        {
            MethodInfo? method = obj.GetType().GetMethod(methodName);
            if (method == null)
            {
                throw new Exception("Method not found.");
            }
            CacheResult? attribute = method.GetCustomAttribute<CacheResult>();
            string cacheKey = $"{methodName}_{input}";
            if (attribute != null && cache.ContainsKey(cacheKey))
            {
                Console.WriteLine("Returning cached result...");
                return cache[cacheKey];
            }
            object? result = method.Invoke(obj, new object[] { input });
            if (attribute != null && result != null)
            {
                cache[cacheKey] = result;
            }
            return result!;
        }
    }
}