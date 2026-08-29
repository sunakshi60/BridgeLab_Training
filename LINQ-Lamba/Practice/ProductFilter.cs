using System;
using System.Collections.Generic;

public class ProductFilter
{
    public static void Solve()
    {
        List<int> prices = new List<int>
        {
            1200,450,89,3400,25,600
        };
        List<int> under500 = prices.FindAll(price => price > 500);
        List<int> between100And1500 = prices.FindAll(price => price > 100 && price <= 1500);
        Console.WriteLine("Prices under 500:");
        foreach (int price in under500)
        {
            Console.WriteLine(price);
        }

        Console.WriteLine("Prices between 100 and 1500:");
        foreach (int price in between100And1500)
        {
            Console.WriteLine(price);
        }
    }
}