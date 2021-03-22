using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class recursion
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 41, 2, 34, 5, 3, 7, 6, 75, 45, 2 };
            Print(numbers, 0);
            Console.WriteLine("recursion Completed");
        }
        private static void Print(int[] numbers,int currentElementindex)
        {
            Console.WriteLine(numbers[currentElementindex]);
            if (currentElementindex < numbers.Length - 1)
            {
                Print(numbers, currentElementindex + 1);
            }
        }
    }
}
