using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Customer : Person
    {
        private List<Order> order_list = new List<Order>();

        public Customer(string name, string phone, string adress) : base(name,phone,adress)
        {
            this.name = name;
            this.phone = phone;
            this.adress = adress;

        }

        public void AddOrder(Order order)
        {
            order_list.Add(order);
        }

        public override string ToString()
        {
            return String.Format("Customer Name:{0}", this.name);
        }

    }
}
