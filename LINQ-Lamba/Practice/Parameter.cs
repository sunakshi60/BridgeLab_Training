using System;

public class ParameterAsLambda
{
    public static int ApplyTwice(int value,Func<int,int> op)
    {
        return op(value);        //10
        //return op(op(value));  //20
    }

    public static void Solve()
    {
        int result = ApplyTwice(5, x => x * 2);
        Console.WriteLine(result);
    }

}