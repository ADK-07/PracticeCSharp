using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Swapping
    {
        public void SwappingWithTemp(int a , int b)
        {
            Console.WriteLine(" Before swapping A and B is {0} and {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping A and B is {0} and {1}", a, b);
        }

        public void SwappingWithOutTemp(int a, int b)
        {
            Console.WriteLine(" Before swapping A and B is {0} and {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping A and B is {0} and {1}", a, b);
        }
    }
}
