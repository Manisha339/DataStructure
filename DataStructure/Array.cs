using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Array
    {
        public static void Do()
        {
            string[] students;
            students = new string[5] {"abc","def","ghi","jkl","mno"};
            string[] subjects = new string[5];
            subjects[0] = "Math";
            subjects[1] = "physics";
            subjects[2] = "english";

            int[] marks = new int[5];
            marks[0] = 67;
            marks[1] = 65;
            marks[2] = 63;
            marks[3] = 68;
            marks[4] = 87;
            Console.Write("Students are:");
            foreach(string s in students)
            {
                Console.Write(s + "  ");
            }

            Console.WriteLine("");
            Console.Write("Subjects are: ");
            foreach (string s in subjects)
            {
                Console.Write(s + "  ");
            }

            Console.WriteLine("");
            Console.Write("Marks are: ");
            int su = 0;
            foreach (int s in marks)
            {
                su += s;
            }

            Console.WriteLine("Total Marks are:"+su);
            Console.WriteLine("Total persentage: " + (su * 100) / 500);
        }
    }
}
