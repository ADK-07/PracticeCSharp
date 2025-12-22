using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringLargestWord
    {
        public void FindLargestWord()
        {
            Console.Write("Enter the string : ");
            string? input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String cannot be empty.");
                return;
            }
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string largestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length > largestWord.Length)
                {
                    largestWord = word;
                }
            }

            Console.WriteLine($"Largest word is : {largestWord}");

        }
    }
}
