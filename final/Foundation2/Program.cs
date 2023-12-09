
using System; 
class Program 
{
    static void Main(string[] args)
    {
        BankAccount b = new BankAccount(20000);
  
        b.Deposit(8000);
        Console.WriteLine("Balance: " + b.GetBalance());
  
        b.Withdraw(32000);
        Console.WriteLine("Balance: " + b.GetBalance());
    }
}