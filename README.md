# Homework 1 C# Exercise: Implementing a Bank Account

## Exercise Description
In this exercise, you will implement a bank account class in C#. The methods should return messages to the user to indicate whether the operation was successful or not.

## Requirements

### Class: BankAccount
Create a class named `BankAccount` with the following functionalities:

#### 1. Opening a Bank Account
- Implement a constructor that allows the user to specify an initial deposit amount
- The initial deposit must be a positive value
- If an invalid (negative or zero) initial amount is provided, raise an error (`throw new ArgumentException();`)



#### 2. Deposit
- Implement a method to deposit money
- The method should accept a positive amount as a parameter
- Upon successful deposit, the account balance should be increased
- Return messages:
  - On success: "Deposit successful"
  - For negative amount: "Error: Deposit amount must be positive"
  - For amount of 0: "Error: Deposit amount must be greater than 0"

#### 3. Withdrawal
- Implement a method to withdraw money
- The method should accept a positive amount as a parameter
- The account balance should not become negative after the withdrawal
- Return messages:
  - On success: "Withdrawal successful"
  - For insufficient balance: "Error: Insufficient funds available"
  - For negative amount: "Error: Withdrawal amount must be positive"
  - For amount of 0: "Error: Withdrawal amount must be greater than 0"

#### 4. Account Balance
- Implement a read-only property to retrieve the current account balance
- The balance should be displayed with 2 decimal places

## Test Cases
Your implementation should pass the following test cases:

### Opening a Bank Account
1. Open an account with a positive initial deposit (e.g., 1000.00) → Success
2. Attempt to open an account with a negative initial deposit → Error message
3. Attempt to open an account with an initial deposit of 0 → Error message

### Deposit
1. Deposit 100.00 → "Deposit successful"
2. Deposit -50.00 → "Error: Deposit amount must be positive" 
3. Deposit 0.00 → "Error: Deposit amount must be greater than 0"

### Withdrawal
1. Withdraw 50.00 from an account with 100.00 → "Withdrawal successful"
2. Attempt to withdraw 200.00 from an account with 100.00 → "Error: Insufficient funds available"
3. Attempt to withdraw -50.00 → "Error: Withdrawal amount must be positive"
4. Attempt to withdraw 0.00 → "Error: Withdrawal amount must be greater than 0"

### Account Balance
1. Verify the balance after a 100.00 deposit → 100.00
2. Verify the balance after a 30.00 withdrawal → 70.00
3. Verify the balance after multiple transactions

## Example Usage
```csharp
// Example usage of the BankAccount class
BankAccount account = new BankAccount(1000.00m);

string result1 = account.Deposit(500.00m);
Console.WriteLine(result1);               // Output: "Deposit successful"
Console.WriteLine(account.Balance);       // Output: 1500.00

string result2 = account.Withdraw(800.00m);
Console.WriteLine(result2);               // Output: "Withdrawal successful"
Console.WriteLine(account.Balance);       // Output: 700.00

string result3 = account.Withdraw(800.00m);
Console.WriteLine(result3);               // Output: "Error: Insufficient funds available"
Console.WriteLine(account.Balance);       // Output: 700.00
```

## Extension Possibilities (!!! Optional !!!)
- Implement account number
- Maintain a transaction history
- Different account types (Checking, Savings, etc.)
- Overdraft limit
- Calculate interest
- Multilingual error messages

## Learning Objectives
- Using properties in C#
- Implementing methods with return values
- String manipulation
- Data encapsulation
- Input validation
- Working with the Decimal data type