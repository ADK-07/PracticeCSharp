using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ArmstrongEx
    {
        public bool Armstrong(int n)
        {
            int originalNumber = n;
            int length = originalNumber.ToString().Length;
            int sum = 0;
            for ( int i = 0; i < length; i++)
            {
                int remainder = originalNumber % 10;
                sum += (int)Math.Pow(remainder, length);
                originalNumber /= 10;
            }
            if (sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
