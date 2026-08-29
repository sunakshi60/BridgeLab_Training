using System;

public class FilterEven
{
    public static void Solve()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
        var result = nums
            .Where(x => x % 2 == 0)
            .Select(x => x * 2)
            .OrderByDescending(x => x);
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}