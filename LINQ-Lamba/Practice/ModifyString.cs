using System;
using System.Collections.Generic;

public class ModifyString
{
    public static void Solve() {
        Func<string, string> modifyString = str => "*** " + str + " ***";
        string result = modifyString("Welcome");
        Console.WriteLine(result);
    }
}