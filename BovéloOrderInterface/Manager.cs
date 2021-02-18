using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Manager : Person
    {
        private List<Customer> customers = new List<Customer>();

        public Manager(int id, string name) : base(id, name)
        {

        }
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            this.customers.Remove(customer);
        }
    }
}
}
