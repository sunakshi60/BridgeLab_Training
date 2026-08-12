using System;
using System.Collections.Generic;

public class SetExample
{
    public void Run()
    {
        Console.WriteLine("\n===== SET =====");

        ISet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);

        Console.WriteLine("HashSet:");
        Display(numbers);

        Console.WriteLine("\nContains 20: " + numbers.Contains(20));

        numbers.Remove(10);

        Console.WriteLine("\nAfter Remove 10:");
        Display(numbers);

        Console.WriteLine("\nCount: " + numbers.Count);

        ISet<int> secondSet = new HashSet<int>
            {
                20, 40, 50
            };

        numbers.UnionWith(secondSet);

        Console.WriteLine("\nAfter UnionWith:");
        Display(numbers);

        ISet<int> thirdSet = new HashSet<int>
            {
                20, 40
            };

        numbers.IntersectWith(thirdSet);

        Console.WriteLine("\nAfter IntersectWith:");
        Display(numbers);

        ISet<int> sortedNumbers = new SortedSet<int>
            {
                50, 10, 30, 20, 40
            };

        Console.WriteLine("\nSortedSet:");
        Display(sortedNumbers);
    }

    private void Display(ISet<int> set)
    {
        foreach (int number in set)
        {
            Console.WriteLine(number);
        }
    }
}