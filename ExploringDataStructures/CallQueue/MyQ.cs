using System;
using System.Collections.Generic;
using System.Text;

namespace CallQueue
{
    internal class MyQ
    {
        MyLinkedList<Customer> customers = new MyLinkedList<Customer>();

        public void Enqueue(Customer customer)
        {
           customers.AddLast(customer);
        }
        public Customer Dequeue()
        {
            if (customers.IsEmpty())
                throw new Exception("Queue is empty!");
            return customers.RemoveFirst();
        }
        public void Print()
        {
            customers.Print();
        }
    }
}
