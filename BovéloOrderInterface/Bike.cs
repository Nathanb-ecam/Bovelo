using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Bike
    {
        private int idBike;
        private Type type;
        private Size size;
        private Color color;
        private Parts partsList;
        private double price;

        //Constructor
        public Bike(int idBike, double price)
        {
            this.idBike = idBike;
            this.price = price;
        }

        public int IdBike
        {
            get { return idBike; }
            set { idBike = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.idBike, this.price);
        }
    }
}
