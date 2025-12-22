using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringPallindrome
    {
        public void CheckPallindrome()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();
            string reversed = " ";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input.Equals(reversed.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }
        }
    }
}
