using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Customer : Person
    {
        private Order order;

        public Customer(int id, string name) : base(id, name)
        {
            
        }

        public void SetOrder (Order order)
        {
            this.order = order;
        }

        // bikes is private, no access to it here( getter setter)
        /* 
        public void ModifyOrder(Bike bike, int number)
        {
            this.order.bikes[bike] = number;
        }
        */
        public Order GetOrder()
        {
            return this.order;
        }

    }
}
