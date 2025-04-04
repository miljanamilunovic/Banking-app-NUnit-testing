using BankingApp;
using NUnit.Framework;

namespace TestBankingApp
{
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(100);
        }

        [Test]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            account.Deposit(50);
            Assert.AreEqual(150, account.Balance);
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => account.Deposit(-50));
        }

        [Test]
        public void Withdraw_PositiveAmount_DecreasesBalance()
        {
            account.Withdraw(50);
            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_AmountGreaterThanBalance_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => account.Withdraw(-50));
        }

        [Test]
        public void Transfer_ValidAmount_UpdatesBothAccounts()
        {
            var targetAccount = new BankAccount(50);
            account.Transfer(targetAccount, 50);

            Assert.AreEqual(50, account.Balance);
            Assert.AreEqual(100, targetAccount.Balance);
        }

        [Test]
        public void Transfer_AmountGreaterThanBalance_ThrowsInvalidOperationException()
        {
            var targetAccount = new BankAccount(50);
            Assert.Throws<InvalidOperationException>(() => account.Transfer(targetAccount, 150));
        }

        [Test]
        public void Transfer_ToNullAccount_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => account.Transfer(null, 50));
        }
    }
}