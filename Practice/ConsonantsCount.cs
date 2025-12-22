using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ConsonantsCount
    {
        public void CountConsonants()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim().ToLower();
            int consonantCount = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c) && !"aeiou".Contains(c))
                {
                    consonantCount++;
                }
            }
            Console.WriteLine($"Consonant count -> {consonantCount}");
        }
    }
}
