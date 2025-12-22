using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReverseEachWordInString
    {
        public void ReverseWords()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim();
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                char[] arr = words[i].ToCharArray();
                Array.Reverse(arr);
                words[i] = new string(arr);
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
