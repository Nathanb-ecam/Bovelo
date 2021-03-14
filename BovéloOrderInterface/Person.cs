using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Person
    {
        protected string name;
        protected string phone;
        protected string adress;
        public Person (string name,string phone, string adress)
        {
            this.name = name;
            this.phone = phone;
            this.adress = adress;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Phone
        {
            get { return this.phone; }

        }

        public string Adress
        {
            get { return this.adress; }

        }

    }
}
