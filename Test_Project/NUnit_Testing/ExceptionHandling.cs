using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class ExceptionHandling
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException("Division by zero is not allowed.");
            }

            return a / b;
        }
    }
}
