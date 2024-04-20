using System;

public class Account
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
            balance = value;
        }
    }

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }
        Balance -= amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account(1000);

        account.Deposit(500);
        Console.WriteLine("New balance after deposit: " + account.Balance);

        account.Withdraw(200);
        Console.WriteLine("New balance after withdrawal: " + account.Balance);

        try
        {
            account.Withdraw(1500);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
