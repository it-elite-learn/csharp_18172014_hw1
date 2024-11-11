namespace Banking;

/// <summary>
/// Represents a basic bank account that supports deposits and withdrawals.
/// </summary>
public class BankAccount
{
    /// <summary>
    /// The current balance of the account.
    /// </summary>
    private decimal balance;

    /// <summary>
    /// Initializes a new instance of the BankAccount class with an initial deposit.
    /// </summary>
    /// <param name="initialDeposit">The initial amount to deposit into the account. Must be positive.</param>
    /// <returns>A string indicating whether the account creation was successful or failed.</returns>
    public BankAccount(decimal initialDeposit)
    {
        if (initialDeposit <= 0)
        {
            throw new ArgumentException("Initial deposit must be greater than 0");
        }

        balance = initialDeposit;
    }

    /// <summary>
    /// Gets the current balance of the account.
    /// </summary>
    /// <value>The current balance with two decimal places.</value>
    public decimal Balance => Math.Round(balance, 2);

    /// <summary>
    /// Deposits money into the account.
    /// </summary>
    /// <param name="amount">The amount to deposit. Must be positive.</param>
    /// <returns>A string indicating whether the deposit was successful or failed.</returns>
    public string Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return amount < 0
                ? "Error: Deposit amount must be positive"
                : "Error: Deposit amount must be greater than 0";
        }

        balance += amount;
        return "Deposit successful";
    }

    /// <summary>
    /// Withdraws money from the account.
    /// </summary>
    /// <param name="amount">The amount to withdraw. Must be positive and less than or equal to the current balance.</param>
    /// <returns>A string indicating whether the withdrawal was successful or failed.</returns>
    public string Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return amount < 0
                ? "Error: Withdrawal amount must be positive"
                : "Error: Withdrawal amount must be greater than 0";
        }

        if (amount > balance)
        {
            return "Error: Insufficient funds available";
        }

        balance -= amount;
        return "Withdrawal successful";
    }

    /// <summary>
    /// Returns the current account balance formatted to two decimal places.
    /// </summary>
    /// <returns>A string representing the formatted account balance.</returns>
    public string BalanceFormated()
    {
        return balance.ToString("F2");
    }
}