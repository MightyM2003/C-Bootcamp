using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void ViewBalance()
    {
        Console.WriteLine("Your current balance is: $" + balance);
    }

    public void AddBalance(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"You added ${amount}. New balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Please enter a positive amount.");
        }
    }

    public void RemoveBalance(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"You removed ${amount}. New balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient funds.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);  // Starting with $1000

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Bank Account Management System!");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Add Balance");
            Console.WriteLine("3. Remove Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    myAccount.ViewBalance();
                    break;
                case "2":
                    Console.Write("Enter amount to add: $");
                    decimal addAmount = Convert.ToDecimal(Console.ReadLine());
                    myAccount.AddBalance(addAmount);
                    break;
                case "3":
                    Console.Write("Enter amount to remove: $");
                    decimal removeAmount = Convert.ToDecimal(Console.ReadLine());
                    myAccount.RemoveBalance(removeAmount);
                    break;
                case "4":
                    Console.WriteLine("Exiting... Thank you for using the Bank Account Management System!");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

