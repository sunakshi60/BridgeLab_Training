using System;
using System.Collections.Generic;

public class ShoppingCart
{
    private Dictionary<string, double> products =new Dictionary<string, double>();

    private List<string> order =new List<string>();

    public void AddProduct(string name, double price)
    {
        if (!products.ContainsKey(name))
        {
            products.Add(name, price);
            order.Add(name);
        }
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nCart Items:");
        foreach (string product in order)
        {
            Console.WriteLine(
                $"{product}: {products[product]}");
        }
    }

    public void DisplaySortedByPrice()
    {
        SortedDictionary<double, List<string>> sorted = new SortedDictionary<double, List<string>>();
        foreach (var product in products)
        {
            if (!sorted.ContainsKey(product.Value))
            {
                sorted[product.Value] =
                    new List<string>();
            }
            sorted[product.Value].Add(product.Key);
        }
        Console.WriteLine("\nItems Sorted By Price:");
        foreach (var item in sorted)
        {
            foreach (string product in item.Value)
            {
                Console.WriteLine(
                    $"{product}: {item.Key}");
            }
        }
    }
}