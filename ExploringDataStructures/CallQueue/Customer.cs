using System;
using System.Collections.Generic;
using System.Text;

namespace CallQueue
{
    internal class Customer
    {
        long CustomerId { get; set; }
        string CustomerName { get; set; }

        public Customer()
        {
            CustomerId = 0;
            CustomerName = string.Empty;
        }
        public Customer(long CustomerId, string CustomerName)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
        }

        public override string ToString()
        {
            return $"Customer ID:{CustomerId}\tName: {CustomerName}"; 
        }
    }
}
