using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SecondMostReapeatedCharacter
    {
        public void FindSecondMostRepeatedCharacter()
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine().Trim();

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
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

            var sortedFreq = freq.OrderByDescending(x => x.Value).ToList();

            if (sortedFreq.Count < 2)
            {
                Console.WriteLine("Not enough unique characters to determine the second most repeated character.");
            }
            else
            {
                var secondMostRepeated = sortedFreq[1];
                Console.WriteLine($"Second most repeated character is '{secondMostRepeated.Key}' with {secondMostRepeated.Value} occurrences.");
            }
        }
    }
}
