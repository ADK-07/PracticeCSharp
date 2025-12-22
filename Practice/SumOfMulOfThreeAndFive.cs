using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SumOfMulOfThreeAndFive
    {
        public int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
