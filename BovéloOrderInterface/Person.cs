using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Person
    {
        protected int id;
        protected string name;
        
        public Person (int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Get_id()
        {
            return this.id;
        }
    }
}
