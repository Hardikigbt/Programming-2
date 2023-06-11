using System;
using System.Collections.Generic;

public class Account
{
    // Constants
    private const int TRANSIT_NUMBER = 314;

    // Fields
    private static int nextAccountNumber;
    public readonly string Number;

    // Properties
    public double Balance { get; private set; }
    public List<string> Names { get; private set; }

    // Static Constructor
    static Account()
    {
        nextAccountNumber = 10_000;
    }

    // Private Constructor
    private Account(string number, string name, double balance)
    {
        Number = number;
        Balance = balance;
        Names = new List<string>();
        Names.Add(name);
    }

    // Public Static Method to Create Account
    public static Account CreateAccount(string name, double balance = 500)
    {
        string accountNumber = $"AC-{TRANSIT_NUMBER}-{nextAccountNumber}";
        nextAccountNumber++;

        return new Account(accountNumber, name, balance);
    }

    // Public Method to Add Name
    public void AddName(string name)
    {
        Names.Add(name);
    }

    // Public Method to Deposit
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    // Public Method to Withdraw
    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    // Override ToString method
    public override string ToString()
    {
        string namesString = string.Join(", ", Names);
        return $"[{Number}] {namesString} ${Balance:F2}";
    }
}
