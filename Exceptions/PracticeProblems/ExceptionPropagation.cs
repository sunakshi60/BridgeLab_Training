using System;

namespace PracticeProblems
{
    public class ExceptionPropagation
    {
        public void Method1()
        {
            int num1 = 10;
            int num2 = 0;
            int result = num1 / num2;
        }

        public void Method2()
        {
            Method1();
        }
    }
}