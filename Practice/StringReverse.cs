using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringReverse
    {
        public void ReverseString()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
