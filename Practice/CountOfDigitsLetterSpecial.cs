using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CountOfDigitsLetterSpecial
    {
        public void Count()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim();

            int letter = 0, digit = 0, special = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    letter++;
                }
                else if (char.IsDigit(c))
                {
                    digit++;
                }
                else
                {
                    special++;
                }

            }
            Console.WriteLine($"Count of Letter -> {letter}, Digits -> {digit}, Special -> {special}");
        }
    }
}
