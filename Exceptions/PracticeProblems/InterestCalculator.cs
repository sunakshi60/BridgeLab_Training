using System;

namespace PracticeProblems
{
    public class InterestCalculator
    {
        public double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException(
                    "Amount and rate must be positive"
                );
            }

            double interest = (amount * rate * years) / 100;

            return interest;
        }
    }
}