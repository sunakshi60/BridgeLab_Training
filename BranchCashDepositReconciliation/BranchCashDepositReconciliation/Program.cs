using BranchCashDepositReconciliation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bank Cash Deposit Reconciliation");
        Console.WriteLine();


        using (var engine = new ReconciliationEngine(10000))
        {
            var batches = new List<DepositBatch>
            {
                new DepositBatch
                {
                    TellerId = "T1",
                    Amount = 3000,
                    TimeStamp = new DateTime( 2026, 9, 1, 10, 30, 0),
                    BranchCode= "BR1"
                },
                new DepositBatch
                {
                    TellerId="T2",
                    Amount=4000,
                    TimeStamp = new DateTime(2026, 9, 1, 11, 00, 0),
                    BranchCode = "BR1"
                },
                new DepositBatch
                {
                    TellerId="T3",
                    Amount=4000,
                    TimeStamp = new DateTime(2026, 9, 1, 19, 00, 0),
                    BranchCode = "BR1"
                },
                new DepositBatch
                {
                    TellerId="T1",
                    Amount=10940,
                    TimeStamp = new DateTime(2026, 9, 1, 1, 00, 0),
                    BranchCode = "BR1"
                },
                new DepositBatch
                {
                    TellerId="T2",
                    Amount=-50,
                    TimeStamp = new DateTime(2026, 9, 1, 23, 00, 0),
                    BranchCode = "BR1"
                },
                 new DepositBatch
                {
                    TellerId="T3",
                    Amount=0,
                    TimeStamp = new DateTime(2026, 9, 1, 13, 00, 0),
                    BranchCode = "BR1"
                },
                 new DepositBatch
                {
                    TellerId = "T1",
                    Amount = 3000,
                    TimeStamp = new DateTime( 2026, 9, 1, 10, 30, 0),
                    BranchCode= "BR1"
                }
            };
            foreach(var batch in batches)
            {
               engine.Reconcile(batch);
            }
            Console.WriteLine();



            Console.WriteLine("Report of all Batches: ");
            var report =engine.GetReport();
            Console.WriteLine(report);
            Console.WriteLine();


            Console.WriteLine("Evening Batch:");
            var eveningBatches = batches
                .Where(b => b.TimeStamp.Hour >= 18)
                .ToList();
            foreach (var batch in eveningBatches)
            {
                Console.WriteLine($"{batch.TellerId} - {batch.Amount}");
            }
            Console.WriteLine();


            Console.WriteLine("Sorted Batch: ");
            var sortedBatches = batches
                .Where(b => b.Amount > 0)
                .OrderByDescending(b => b.Amount)
                .ToList();
            foreach (var batch in sortedBatches)
            {
                Console.WriteLine($"{batch.TellerId} - {batch.Amount}");
            }


            Console.WriteLine();
        }           
    }
}