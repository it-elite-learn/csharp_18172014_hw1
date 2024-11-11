namespace Banking.Test.Unit;

public class BankAccountTests
{
    [Test]
    public void Constructor_WithPositiveInitialDeposit_CreatesAccount()
    {
        // Arrange & Act
        var account = new BankAccount(1000.00m);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(1000.00m));
    }

    [Test]
    public void Constructor_WithNegativeInitialDeposit_ThrowsException()
    {
        // Arrange & Act & Assert
        // ReSharper disable once ObjectCreationAsStatement
        Assert.Throws<ArgumentException>(() => new BankAccount(-100.00m));
    }

    [Test]
    public void Constructor_WithZeroInitialDeposit_ThrowsException()
    {
        // Arrange & Act & Assert
        // ReSharper disable once ObjectCreationAsStatement
        Assert.Throws<ArgumentException>(() => new BankAccount(0m));
    }

    [Test]
    public void Deposit_WithPositiveAmount_ReturnsSuccess()
    {
        // Arrange
        var account = new BankAccount(1000.00m);

        // Act
        string result = account.Deposit(500.00m);

        // Assert
        Assert.That(result, Is.EqualTo("Deposit successful"));
        Assert.That(account.Balance, Is.EqualTo(1500.00m));
    }

    [Test]
    public void Deposit_WithNegativeAmount_ReturnsError()
    {
        // Arrange
        var account = new BankAccount(1000.00m);

        // Act
        string result = account.Deposit(-500.00m);

        // Assert
        Assert.That(result, Is.EqualTo("Error: Deposit amount must be positive"));
        Assert.That(account.Balance, Is.EqualTo(1000.00m));
    }

    [Test]
    public void Withdraw_WithValidAmount_ReturnsSuccess()
    {
        // Arrange
        var account = new BankAccount(1000.00m);

        // Act
        string result = account.Withdraw(500.00m);

        // Assert
        Assert.That(result, Is.EqualTo("Withdrawal successful"));
        Assert.That(account.Balance, Is.EqualTo(500.00m));
    }

    [Test]
    public void Withdraw_WithInsufficientFunds_ReturnsError()
    {
        // Arrange
        var account = new BankAccount(1000.00m);

        // Act
        string result = account.Withdraw(1500.00m);

        // Assert
        Assert.That(result, Is.EqualTo("Error: Insufficient funds available"));
        Assert.That(account.Balance, Is.EqualTo(1000.00m));
    }

    [Test]
    public void Balance_WithTwoDecimalPositions_CorrectFormat()
    {
        // Arrange
        var account = new BankAccount(1000.00m);

        // Act
        string result = account.BalanceFormated();

        // Assert
        Assert.That(result, Is.EqualTo("1000,00"));
    }
}