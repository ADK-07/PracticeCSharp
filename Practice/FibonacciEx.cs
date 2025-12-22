using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class FibonacciEx
    {
        public void Fibonaci()
        {
            Console.Write("Enter the number of terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            int firstElement = 0;
            int secondElement = 1;
            Console.WriteLine("Fibonacci series");
            for (int i = 1; i <= terms; i++) {
                Console.WriteLine(firstElement);
                int nextElement = firstElement + secondElement;
                firstElement = secondElement;
                secondElement = nextElement;
            }
        }
    }
}
