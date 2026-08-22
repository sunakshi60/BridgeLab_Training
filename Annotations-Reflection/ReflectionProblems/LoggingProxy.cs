using System;
using System.Reflection;

interface IGreeting
{
    void SayHello(string name);
}

class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

class LoggingProxy : DispatchProxy
{
    private IGreeting? target;

    public void SetTarget(IGreeting target)
    {
        this.target = target;
    }

    protected override object? Invoke(
        MethodInfo? targetMethod,
        object?[]? args)
    {
        Console.WriteLine(
            $"Calling method: {targetMethod?.Name}");

        return targetMethod?.Invoke(target, args);
    }
}