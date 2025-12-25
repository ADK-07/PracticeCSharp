using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class BankAccounts
    {
        public string HolderName { get; }
        public int AccountNumber { get; }

        public decimal Balance { get; protected set; }

        public BankAccounts(int accountNumber, decimal balance, string holderName)
        {
            this.AccountNumber = accountNumber;
            this.HolderName = holderName;
            this.Balance = balance >= 0 ? balance : 0;
        }

        public void Deposit(decimal amount)
        {
           if ( amount > 0 )
            {
                Balance += amount;
                Console.WriteLine($"Deposited : {amount}");
            }
           else
            {
                    Console.WriteLine("Invalid transaction");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if ( amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn : {amount}");
            }
            else
            {
                Console.WriteLine("Invalid transaction");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Account No: {AccountNumber}");
            Console.WriteLine($"Name      : {HolderName}");
            Console.WriteLine($"Balance   : {Balance}");
        }
    }

    internal class SavingAccount : BankAccounts
    {
        public decimal InterestRate { get; }

        public SavingAccount(int accountNumber, decimal rate, decimal balance, string name) : base (accountNumber, balance, name)
        {
            InterestRate = rate > 0 ? rate : 0;
        }

        public void AddInterest()
        {
            Balance += Balance * InterestRate / 100;
        }
    }

    class CurrentAccount : BankAccounts
    {
        public decimal OverdraftLimit { get; }

        public CurrentAccount(int accNo, decimal overdraft, decimal balance, string name)
            : base(accNo, balance, name)
        {
            OverdraftLimit = overdraft;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
                Balance -= amount;
        }
    }
}
