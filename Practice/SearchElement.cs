using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SearchElement
    {
        public void FindElement()
        {
            Console.Write("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the search elements : ");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            int position = 0;

            foreach (int num in arr)
            {
                position++;
                if (num == searchElement)
                {
                    Console.WriteLine($"Element {searchElement} found in the array at positon {position}.");
                    return;
                }
            }
        }
    }
}
