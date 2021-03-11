using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
    class StackProgram
    {
        public Node Root { get; set; }

        public int length { get; set; }

        public Node Current { get; set; }

        public static void Do()
        {
            StackProgram stack = new StackProgram();
            for(int i = 0; i < 10; i++)
            {
                Node n = new Node();
                n.Data = i.ToString();
                stack.Push(n);
            }
            
            Node popednode = stack.Pop();
            Console.WriteLine(popednode.Data);
            popednode = stack.Pop();
            Console.WriteLine(popednode.Data);
            Console.WriteLine(stack.getLength());
            Console.WriteLine(stack.List());
        }
        public void Push(Node node)
        {
            node.Next = null;
            if(Root == null)
            {
                Root = node;
                length = 1;
                Current = node;
                Root.prev = null;
            }
            else
            {
                Current.Next = node;
                node.prev = Current;
                Current = node;
                length++;
            }
        }
        public Node Pop()
        {
            if(Current == null)
            {
                return null;
            }
            else if(Current == Root)
            {
                Node nodetoreturn = Current;
                Current = null;
                Root = null;
                length=0;
                return nodetoreturn;
            }
            else
            {
                Node nodetoreturn = Current;
                Current = Current.prev;
                Current.Next = null;
                length--;
                return nodetoreturn;
            }
        }
        public Node peak()
        {
            if(Current is null || Current.Next is null)
            {
                return null;
            }
            else
            {
                return Current;
            }
        }
        public Node getRoot()
        {
            Current = Root;
            return Root;
        }
        public int getLength()
        {
            return this.length;
        }
        public string List()
        {
            string result = "";
            Current = Root;
            while(Current != null)
            {
                result += Current.Data+" ";
                Current = Current.Next;
                
            }
            Console.WriteLine(result);
            Current = Root;
            return result;

        }
    }
}
