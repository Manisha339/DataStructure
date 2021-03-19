using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class SelectionSort
    {
        public static void Do()
        {
            int[] numbers = new int[5] { 7, 5, 3, 9, 1 };
            int smallest;
            for(int i = 0; i < numbers.Length -1; i++)
            {
                smallest = i;
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = numbers[smallest];
                numbers[smallest] = numbers[i];
                numbers[i] = temp;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
