using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class BankAccountRealWorldExample
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        public BankAccountRealWorldExample(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;

            if ( balance > 0)
            {
                this.balance += balance;
            }
            else
            {
                this.balance = balance;
            }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public string HolderName
        {
            get { return holderName; }
        }

        public double Balance
        {
            get { return balance; }
        }

        //If data change must follow business rules → use METHODS, not set.

        //Properties describe WHAT something is
        //Methods describe WHAT something does
        //Withdraw is an operation, not a value assignment.


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited : {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if ( amount <= 0 )
            {
                Console.WriteLine("Invalid withdraw amount");
            }
            else if ( amount > balance)
            {
                Console.WriteLine("Insufficient balance in the account .");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawed {amount} rupees");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Holder Name : {holderName}");
            Console.WriteLine($"Balance : {balance}");
        }
    }

    
}
