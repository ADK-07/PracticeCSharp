using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CopyArray
    {
        public void CopyArr()
        {
            Console.Write("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] copyArr = new int[size];
            Console.WriteLine("Enter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                copyArr[i] = arr[i];
            }
            Console.WriteLine("Elements of copied array are : ");
            Console.WriteLine(string.Join(", ", copyArr));
        }
    }
}
