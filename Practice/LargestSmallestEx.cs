using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LargestSmallestEx
    {
        public void FindLargestSmallest(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }
            int largest = arr[0];
            int smallest = arr[0];
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
                else if (num < smallest)
                {
                    smallest = num;
                }
            }

            //int largest = arr.Max();
            //int smallest = arr.Min();

            Console.WriteLine("Largest is " + largest);
            Console.WriteLine("Smallest is " + smallest);
        }

        public void FindLarSmaAlt()
        {
            Console.Write("Enter the first number : ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number : ");
            int fourth = Convert.ToInt32(Console.ReadLine());

            int largest = first;
            int smallest = first;

            //if (second > largest) largest = second;
            //if (third > largest) largest = third;
            //if (fourth > largest) largest = fourth;

            //if (second < smallest) smallest = second;
            //if (third < smallest) smallest = third;
            //if (fourth < smallest) smallest = fourth;

            //int largest = Math.Max(Math.Max(first, second), Math.Max(third, fourth));
            //int smallest = Math.Min(Math.Min(first, second), Math.Min(third, fourth));



            Console.WriteLine("Largest is " + largest);
            Console.WriteLine("Smallest is " + smallest);
        }
    }
}
