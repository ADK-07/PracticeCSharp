using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class HollowDiamondPattern
    {
        public void PrintPattern()
        {
            Console.Write("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= ( 2 * i - 1); j++)
                {
                    if (j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
