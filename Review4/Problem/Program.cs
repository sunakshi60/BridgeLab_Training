using System;
using System.Collections.Generic;

class Program
{ 

    public static int[] DailyTemperatures(int[] temp)
    {
        int n = temp.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && temp[i] > temp[stack.Peek()])
            {
                int previousDay = stack.Pop();
                result[previousDay] = i - previousDay;
            }
            stack.Push(i);
        }
        return result;
    }
    static void Main(string[] args)
    {
        int[] Temp = { 73, 74, 75, 71, 69, 72, 76, 73 };
        int[] result = DailyTemperatures(Temp);
        Console.WriteLine("["+string.Join(",",result)+"]");

        Console.ReadLine();
    }
}