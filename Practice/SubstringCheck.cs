using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SubstringCheck
    {
        public void CheckSubstring()
        {
            Console.Write("Enter the main string : ");
            string mainString = Console.ReadLine().Trim();
            Console.Write("Enter the substring to check : ");
            string subString = Console.ReadLine().Trim();
            Console.WriteLine(mainString.Contains(subString) ? "Found" : "Not Found");
        }
    }
}
