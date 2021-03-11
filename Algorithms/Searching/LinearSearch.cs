using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class LinearSearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 7, 8, 5, 6, 0, 21, 24, 67, 12, 87 };
            Console.WriteLine("ENTER THE NUMBER TO SEARCH");
            string input = Console.ReadLine();
            int numtosearch = Convert.ToInt32(input);
            int flag = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numtosearch)
                {
                    Console.WriteLine("Number to search found at: " + i);
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
