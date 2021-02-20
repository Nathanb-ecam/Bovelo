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
        private int price = 0 ;

        public Type(string type)
        {
            this.type = type;
            if (type== "Adventure") {
                this.price = 200;
            }
            else if (type == "Explorer")
            {
                this.price = 150;
            }
            else if (type == "City")
            {
                this.price = 100;
            }


        }

        public string Types
        {
            get { return type;}
            set { type = value;}
        }
        public int Price
        {
            get { return price; }
            
        }

    }
}
