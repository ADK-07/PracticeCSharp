using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringCharFrequency
    {
        public void CharFrequency()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim().ToLower();
            string noSpaceInput = input.Replace(" ", "");

            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in noSpaceInput)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }

            foreach (var item in freq)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
