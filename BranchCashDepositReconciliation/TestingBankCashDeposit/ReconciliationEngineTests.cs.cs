using BranchCashDepositReconciliation;

namespace TestingBankCashDeposit
{
    public class ReconciliationEngineTests
    {
        [Test]
        public void ValidBatch_ShouldBeAccepted()
        {
            var engine = new ReconciliationEngine(10000);
            var batch = new DepositBatch
            {
                TellerId = "T1",
                Amount = 3000,
                TimeStamp = new DateTime(2026, 9, 1, 10, 30, 0),
                BranchCode = "BR1"
            };
            engine.Reconcile(batch);
            Assert.That(
                engine.AcceptedBatches.Count,
                Is.EqualTo(1)
            );
        }

        [Test]
        public void BatchAboveThreshold_ShouldBeFlagged()
        {
            var engine = new ReconciliationEngine(10000);
            var batch = new DepositBatch
            {
                TellerId = "T1",
                Amount = 10940,
                TimeStamp = new DateTime(2026, 9, 1, 16, 00, 0),
                BranchCode = "BR1"
            };
            engine.Reconcile(batch);
            Assert.That(
                engine.FlaggedBatches.Count,
                Is.EqualTo(1)
            );
        }

        [Test]
        public void ZeroAmount_ShouldBeRejected()
        {
            var engine = new ReconciliationEngine(10000);
            var batch = new DepositBatch
            {
                TellerId = "T3",
                Amount = 0,
                TimeStamp = new DateTime(2026, 9, 1, 13, 00, 0),
                BranchCode = "BR1"
            };
            engine.Reconcile(batch);
            Assert.That(
                engine.RejectedCount,
                Is.EqualTo(1)
            );
        }

        [Test]
        public void NegativeAmount_ShouldBeRejected()
        {
            var engine = new ReconciliationEngine(10000);
            var batch = new DepositBatch
            {
                TellerId = "T2",
                Amount = -50,
                TimeStamp = new DateTime(2026, 9, 1, 14, 00, 0),
                BranchCode = "BR1"
            };
            engine.Reconcile(batch);
            Assert.That(
                engine.RejectedCount,
                Is.EqualTo(1)
            );
        }

        [Test]
        public void NullTellerId_ShouldThrowArgumentNullException()
        {
            using var engine = new ReconciliationEngine(10000);
            var batch = new DepositBatch
            {
                TellerId = null,
                Amount = 3000,
                TimeStamp = DateTime.Now,
                BranchCode = "BR1"
            };
            Assert.Throws<ArgumentNullException>(
                () => engine.Reconcile(batch)
            );
        }

        [Test]
        public void DisposeTwice_ShouldNotThrow()
        {
            var engine = new ReconciliationEngine(10000);
            Assert.DoesNotThrow(() =>
            {
                engine.Dispose();
                engine.Dispose();
            });
        }
    }
}
