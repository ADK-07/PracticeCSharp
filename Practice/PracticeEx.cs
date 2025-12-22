using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Practice
{
    internal class PracticeEx
    {
        public void Greet()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int largest = arr[0];
            int second = arr[0];

            foreach (int num in arr)
            {
                if(num > largest)
                {
                    second = largest;
                    largest = num;
                }
                else if (num > second && num != largest)
                {
                    second = num;
                }
            }
            Console.WriteLine($"Second largest in the array is {second}");
        }
        
    }
}
