using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{ 
    class Agent : Person
    {
        private List<Customer> customers = new List<Customer>();
        private int id_agent;
        public Agent(string name,int id,string phone, string adress) : base(name,phone,adress)
        {
            this.id_agent = id;
        }

        public int Id
        {
            get { return id_agent; }
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


