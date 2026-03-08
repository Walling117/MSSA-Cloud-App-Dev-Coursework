using System;
using System.Collections.Generic;
using System.Text;

namespace CallQueue
{
    internal class MyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public  MyLinkedList() 
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0; 
        }
        public void AddFirst(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (IsEmpty())
            {
                tail = newNode;
            }
            else
            {
                newNode.next = head;
            }
                head = newNode;
            size++;
        }
        public void AddLast(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (IsEmpty())
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }
        public T RemoveFirst()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("List is empty!");
            Node<T> firstElement = head;
            head = head.next;
            size--;
            if (IsEmpty())
                tail = null;
            return firstElement.Data;
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty!");

            Node<T> node = head;
                return node.Data;
        }

        public void Print()
        {
            Node<T> node = head;
            int i = 1;
            while (node != null)
            {               
                Console.WriteLine($"{i}.{node.Data.ToString()}");
                node = node.next;
                i++;
            }

        }
    }
}
