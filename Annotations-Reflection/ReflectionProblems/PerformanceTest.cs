using System;

class PerformanceTest
{
    public void FastMethod()
    {
        for (int i = 0; i < 100000; i++)
        {
            int x = i * i;
        }
    }

    public void SlowMethod()
    {
        for (int i = 0; i < 10000000; i++)
        {
            int x = i * i;
        }
    }

    public void AnotherMethod()
    {
        for (int i = 0; i < 5000000; i++)
        {
            int x = i * i;
        }
    }
}