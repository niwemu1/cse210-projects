using System;

public class BankAccount 
{
    private decimal balance;
  
    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }
  
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
  
    public void Withdraw(decimal amount)
    {
        if (balance >= amount) 
        {
            balance -= amount;
        }
        else 
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
  
    public decimal GetBalance() { return balance; }
}