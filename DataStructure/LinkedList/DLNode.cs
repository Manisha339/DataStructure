using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class DLNode
    {
        private string data;
        private Node next = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DLNode Next { get; set; }
        public DLNode Prev { get; set; }
    }
}
