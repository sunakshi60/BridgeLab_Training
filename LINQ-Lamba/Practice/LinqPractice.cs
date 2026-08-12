using System;
using System.Collections.Generic;
using System.Linq;

public class LinqPractice
{
    public static void Solve()
    {
        List<int> num = new List<int> { 1, 2, 3 };

        //var query = num.Where(num => num > 1);

        var query = num.Where(n => n > 1).ToList();
        num.Add(4);
        
        foreach(var n in query)
        {
            Console.Write(" "+n);
        }
     }
}