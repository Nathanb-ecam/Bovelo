using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Type
    {
        private string type;

        public Type(string type)
        {
            this.type = type;
        }

        public string Types
        {
            get { return type;}
            set { type = value;}
        }

    }
}
