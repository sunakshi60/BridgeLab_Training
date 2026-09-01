using System;
using System.Collections.Generic;
using System.Text;

namespace BranchCashDepositReconciliation
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuditableAttribute : Attribute
    {
        public string Category { set; get; }
    }
}
