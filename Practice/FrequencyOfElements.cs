using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class FrequencyOfElements
    {
        public void FrequencyCount()
        {
            Console.Write("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool[] visited = new bool[size];

            for(int i = 0; i < size; i++)
            {
                if (visited[i]) continue;

                int count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                Console.WriteLine(arr[i] + " occurs " + count + " times ");
            }
        }
    }
}
