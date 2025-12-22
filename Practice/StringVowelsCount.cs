using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringVowelsCount
    {
        public void CountVowels()
        {
            Console.Write("Enter the string : ");
            string input = Console.ReadLine().ToLower();
            int vowelsCount = 0;

            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine($"vowels count is {vowelsCount}");
        }
    }
}
