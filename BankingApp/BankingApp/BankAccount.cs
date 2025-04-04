

namespace BankingApp
{
    public class BankAccount
{
    public int Balance { get; private set; }

    public BankAccount(int initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }
        Balance -= amount;
    }

    public void Transfer(BankAccount targetAccount, int amount)
    {
        if (targetAccount == null)
        {
            throw new ArgumentNullException(nameof(targetAccount));
        }
        Withdraw(amount);
        targetAccount.Deposit(amount);
    }
}
}