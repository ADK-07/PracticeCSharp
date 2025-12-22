using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LargestElement
    {
        public void FindLargest()
        {
            Console.Write("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of array.");

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = arr[0];

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine($"Largest element in the array is {largest}");
        }
    }
}
