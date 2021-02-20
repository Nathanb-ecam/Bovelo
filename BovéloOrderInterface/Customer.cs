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
        private static int id_customer =0;
        public Customer(string name) : base(name)
        {
            id_customer++;
        }

        public void SetOrder (Order order)
        {
            this.order = order;
        }        

        public Order GetOrder()
        {
            return this.order;
        }

        public int Id
        {
            get{ return id_customer; }
        }

        public override string ToString()
        {
            return String.Format("Order ID : {0} Customer ID :{1}", order.ToString(), Id);
        }

    }
}
