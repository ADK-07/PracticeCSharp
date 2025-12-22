using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringWordCount
    {
        public void CountWords()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim();

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"word count -> {words.Length}");
            
        }
    }
}
