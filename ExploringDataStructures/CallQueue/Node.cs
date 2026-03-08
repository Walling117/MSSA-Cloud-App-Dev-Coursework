using System;
using System.Collections.Generic;
using System.Text;

namespace CallQueue
{
    internal class Node<T>
    {
      public  Node<T> next;
        public T Data { get; set; } 
        public Node(T node)
        {
            this.Data = node;
            next = null;
        }

    }
}
