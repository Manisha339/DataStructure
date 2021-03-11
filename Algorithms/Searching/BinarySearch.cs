using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class BinarySearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 67, 85, 98 };
            Console.WriteLine("ENTER THE NUMBER TO SEARCH");
            string input = Console.ReadLine();
            int numtosearch = Convert.ToInt32(input);
            int flag = 0;
            int min = 0;
            int max = numbers.Length - 1;
            while(min<max && flag == 0)
            {
                int midele = (min + max) / 2;
                if(numbers[midele] == numtosearch)
                {
                    flag = midele;
                    break;
                }
                else if(numtosearch< numbers[midele])
                {
                    max = midele - 1;
                }
                else
                {
                    min = midele + 1;
                }
            }
            Console.WriteLine("Element Found at index: " + flag);
        }
    }
}
