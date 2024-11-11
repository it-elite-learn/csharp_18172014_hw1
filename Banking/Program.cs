using Banking;

// Create a new account with initial deposit
BankAccount account = new(1000.00m);
Console.WriteLine($"Account created with balance: {account.Balance}");

// Perform some transactions
string depositResult = account.Deposit(500.00m);
Console.WriteLine($"{depositResult} - New balance: {account.Balance}");

string withdrawResult = account.Withdraw(300.00m);
Console.WriteLine($"{withdrawResult} - New balance: {account.Balance}");

// Try some invalid operations
string invalidDeposit = account.Deposit(-100.00m);
Console.WriteLine(invalidDeposit);

string invalidWithdraw = account.Withdraw(2000.00m);
Console.WriteLine(invalidWithdraw);