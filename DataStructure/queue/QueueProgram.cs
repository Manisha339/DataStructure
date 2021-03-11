using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.queue
{
    class QueueProgram
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;

        public static void Do()
        {
            QueueProgram queue = new QueueProgram(10);
            queue.insert(10);
            queue.insert(20);
            queue.insert(10);
            queue.insert(30);
            queue.insert(40);
            queue.insert(10);
            queue.insert(50);
            queue.insert(70);
            queue.insert(60);
            queue.insert(80);
            Console.WriteLine(queue.printQueue());
            queue.delete();
            queue.delete();
            Console.WriteLine(queue.printQueue());
        }
        public QueueProgram(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if(rear == max-1 )
            {
                return;
            }
            else
            {
                elements[++rear] = item;
            }
        }
        public int delete()
        {
            if (front == rear + 1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine(elements[front]);
                return elements[front++];
            }
        }
        public string printQueue()
        {
            string result = "";
            if(front == rear + 1)
            {
                return result;
            }
            else
            {
                for(int i=front; i< rear+1; i++)
                {
                    result += elements[i] + " ";
                }
                return result;
            }
        }
    }
}
