using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class SingleLinkedList
    {
        private Node root = null;
        
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length { get; set; }
        public Node Current { get; set; }
        public static void Do()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node node = new Node();
            node.Data = "root";
            list.Add(node);
            for(int i = 0; i < 10; i++)
            {
                Node node1 = new Node();
                node1.Data = i.ToString();
                list.Add(node1);
            }
            Console.WriteLine("length of linked list: " + list.getLength());

            Node NodeToread = list.getRoot();
            while(NodeToread != null)
            {
                Console.WriteLine(NodeToread.Data);
                NodeToread = list.getNext();
            }

        }
        public void Add(Node node)
        {
            node.Next = null;
            if (root is null)
            {
                root = node;
                length = 1;
                Current = root;
            }
            else
            {
                Current.Next = node;
                Current = node;
                length++ ;
            }
        }
        public Node getCurrent()
        {
            return this.Current;
        }
        public Node getRoot()
        {
            Current = root;
            return this.root;
        }

        public Node getNext()
        {
            if(Current.Next is null)
            {
                return null;
            }
            else
            {
                Current = Current.Next;
                return Current;
            }
        }

        public int getLength()
        {
            return this.length;
        }
    }
}
