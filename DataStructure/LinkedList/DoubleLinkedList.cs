using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class DoubleLinkedList
    {
        private DLNode root = null;

        public DLNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length { get; set; }
        public DLNode Current { get; set; }
        public static void Do()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            DLNode node = new DLNode();
            node.Data = "Root";
            list.Add(node);
            for(int i = 0; i < 10; i++)
            {
                DLNode node1 = new DLNode();
                node1.Data = i.ToString();
                list.Add(node1);
            }
            Console.WriteLine("length of linked list: " + list.getLength());
            Console.WriteLine("Reading data for traversing Forword");
            DLNode NodeToread = list.getRoot();
            while (NodeToread != null)
            {
                Console.WriteLine(NodeToread.Data);
                NodeToread = list.getNext();
            }
            Console.WriteLine("Reading data for traversing Backword");
            NodeToread = list.getCurrent();
            while(NodeToread != null)
            {
                Console.WriteLine(NodeToread.Data);
                NodeToread = list.getPrev();
            }

        }
        public void Add(DLNode node)
        {
            node.Next = null;
            if(root == null)
            {
                root = node;
                Length = 1;
                Current = root;
                root.Prev = null;
            }
            else
            {
                Current.Next = node;
                node.Prev = Current;
                Current = node;
                Length++;
            }
        }
        public DLNode getCurrent()
        {
            return this.Current;
        }
        public DLNode getRoot()
        {
            Current = root;
            return this.root;
        }

        public DLNode getNext()
        {
            if (Current.Next is null)
            {
                return null;
            }
            else
            {
                Current = Current.Next;
                return Current;
            }
        }
        public DLNode getPrev()
        {
            if (Current.Prev == null)
            {
                return null;
            }
            else
            {
                Current = Current.Prev;
                return Current;
            }
        }
        public int getLength()
        {
            return this.Length;
        }
    }
}
