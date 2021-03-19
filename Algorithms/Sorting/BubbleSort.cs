using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        public static void Do()
        {
            string[] names = new string[5];
            names[0] = "mani";
            names[1] = "nani";
            names[2] = "jithu";
            names[3] = "naresh";
            names[4] = "jamuna";
            for(int i = 1; i < names.Length ; i++)
            {
                for(int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j + 1].CompareTo(names[j]) < 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }

            foreach(string na in names)
            {
                Console.WriteLine(na);
            }
        }
    }
}
