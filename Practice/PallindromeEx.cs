using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class PallindromeEx
    {
        public void Pallindrome(int n)
        {
            int originalNumber = n;
            int length = originalNumber.ToString().Length;
            int reverse = 0;
            while( originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                reverse = (reverse * 10) + remainder;
                originalNumber /= 10;
            }
            if (reverse == n)
            {
                Console.WriteLine("Number is a Pallindrome");
            }
            else
            {
                Console.WriteLine("Number is not a Pallindrome");
            }
        }
    }
}
