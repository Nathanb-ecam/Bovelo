using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Parts
    {
        private int idPart;
        private string name;
        private double price;

        public Parts(int idPart, string name, double price)
        {
            this.idPart = idPart;
            this.name = name;
            this.price = price;

        }

        public int IdPart
        {
            get { return idPart; }
            set { idPart = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
