using System;
using System.Collections.Generic;
using System.Text;

namespace BranchCashDepositReconciliation
{
    public class ReconciliationReport
    {
        public int Accepted { get; set; }
        public int Rejected { get; set; }
        public int Flagged { get; set; }
        public override string ToString()
        {
            return $"Accepted : {Accepted}, " + $"Rejected: {Rejected} ," + $"Flagged : {Flagged}";
        }
    }
}
