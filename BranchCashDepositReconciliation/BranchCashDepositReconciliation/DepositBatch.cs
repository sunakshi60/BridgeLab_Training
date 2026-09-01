using System;
using System.Collections.Generic;
using System.Text;

namespace BranchCashDepositReconciliation
{
    public class DepositBatch
    {
        public string TellerId { get; set; }
        public decimal Amount{ get; set; }
        public DateTime TimeStamp { get; set; }
        public string BranchCode { get; set; }    
    }
}
