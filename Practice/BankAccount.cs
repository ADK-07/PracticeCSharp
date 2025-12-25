using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Encapsulation using property
    internal class BankAccount
    {
        private decimal balance;

        // use properties for data filed and method for actions 

        public decimal Balance
        {
            get { return balance; }
        }

        public int Deposit
        {
            set
            {
                if ( value > 0)
                {
                    balance += value;
                }
            }
        }
    }

    //Encapsulation using method
    internal class UserAccount
    {
        public required string Name { get; set; }
        private  string password = String.Empty;

        public void SetPassword(string newPassword)
        {
            if (!string.IsNullOrEmpty(newPassword) && newPassword.Length >= 6)
            {
                password = newPassword;
                Console.WriteLine("password set successfully");
            } else
            {
                Console.WriteLine("password must not be null and must have atleast 6 characters");
            }
        }

        public bool CheckPassword(string newPassword)
        {
            return password == newPassword;
        }
    }
}
