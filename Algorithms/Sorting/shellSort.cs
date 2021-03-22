using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class shellSort
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 12, 45, 23, 1, 47, 68, 9, 4, 5, 34 };
            int arrayLength = numbers.Length;
            for(int gap = arrayLength / 2; gap > 0; gap/=2)
            {
                for(int i = gap; i < arrayLength; i++)
                {
                    int valueforiteration = numbers[i];
                    int j;
                    for (j = i; j >= gap && numbers[j - gap] > valueforiteration; j -= gap)
                    {
                        numbers[j] = numbers[j - gap];

                    }
                    numbers[j] = valueforiteration;
                }
            }
            foreach(int i in numbers) {
                Console.WriteLine(i);
            }
            
        }
    }
}
