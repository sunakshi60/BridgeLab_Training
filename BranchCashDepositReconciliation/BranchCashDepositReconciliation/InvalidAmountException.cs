using System;
using System.Collections.Generic;

namespace BranchCashDepositReconciliation
{
    public class InvalidAmountException : Exception
    {
        public  InvalidAmountException()
        {
        }

        public  InvalidAmountException(string message): base(message)
        {
        }

        public  InvalidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
