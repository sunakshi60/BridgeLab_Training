using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace BranchCashDepositReconciliation
{
    public class ReconciliationEngine : IDisposable
    {
        private Func<DepositBatch, bool> flagRule;
        public List<DepositBatch> AcceptedBatches  = new List<DepositBatch>();
        public List<DepositBatch> FlaggedBatches  = new List<DepositBatch>();
        public int RejectedCount { get; set; }
        public event Action<DepositBatch> BatchFlagged;

        public ReconciliationEngine(decimal maxAmount)
        {
            flagRule = CreateThresholdRule(maxAmount);   
            BatchFlagged += batch =>
            {
                Console.WriteLine( $"FLAGGED: Teller={batch.TellerId}, Amount={batch.Amount}");
            };

            BatchFlagged += batch =>
            {
                FlaggedBatches.Add(batch);
            };
        }

        private Func<DepositBatch, bool> CreateThresholdRule(decimal maxAmount)
        {
            return batch => batch.Amount >= maxAmount;
        }

        public void Reconcile(DepositBatch batch)
        {
            try
            {
                ValidateBatch(batch);

                ProcessBatch(batch);

                if (flagRule(batch))
                {
                    BatchFlagged?.Invoke(batch);
                }
                else
                {
                    AcceptedBatches.Add(batch);
                }
            }
            catch (InvalidAmountException ex)
            {
                RejectedCount++;
                Console.WriteLine($"Rejected: {ex.Message}");
            }
        }

        private void ValidateBatch(DepositBatch batch)
        {
            if (batch == null)
            {
                throw new ArgumentNullException(nameof(batch));
            }
            if (batch.TellerId == null)
            {
                throw new ArgumentNullException(nameof(batch.TellerId));
            }
            if (batch.Amount <= 0)
            {
                throw new InvalidAmountException($"Invalid amount: {batch.Amount}");
            }
        }

        [Auditable(Category = "Cash")]
        private void ProcessBatch(DepositBatch batch)
        {
            MethodInfo method =
                GetType().GetMethod(
                    "ProcessBatch",
                    BindingFlags.NonPublic | BindingFlags.Instance
                );

            AuditableAttribute attribute = method.GetCustomAttribute<AuditableAttribute>();

            Console.WriteLine($"AUDIT: Category={attribute.Category}, " + $"Teller={batch.TellerId}, " + $"Amount={batch.Amount}");
        }

        public ReconciliationReport GetReport()
        {
            return new ReconciliationReport
            {
                Accepted = AcceptedBatches.Count,
                Flagged = FlaggedBatches.Count,
                Rejected = RejectedCount
            };
        }

        public void Dispose()
        {
            Console.WriteLine("ReconciliationEngine disposed.");
        }
    }

}
