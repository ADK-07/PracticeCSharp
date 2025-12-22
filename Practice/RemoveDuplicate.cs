using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class RemoveDuplicate
    {
        public void RemoveDuplicates()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine().Trim();

            string result = "";

            foreach (char  ch in input)
            {
                if (!result.Contains(ch))
                    result += ch;
            }

            Console.WriteLine($"String after removing duplicates : {result}");
        }
    }
}
