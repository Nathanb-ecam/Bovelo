using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bovelo
{
    public class Bike
    {
        private static int idBike=0;
        private Type type;
        private Size size;
        private Color color;
        private Parts partsList;
        private double price;
        private int id;
        //Constructor
        public Bike(Type type, Size size, Color color,double price)
        {
            this.id = idBike;
            idBike++;
            this.price = price;
            this.type = type;
        }

        public int IdBike
        {
            get { return idBike; }
            set { idBike = value; }
        }

        public Type Type
        {
            get { return type; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
 

        public override string ToString()
        {
            return String.Format("{0} {1}", this.type.Types, this.price);
        }

    }
}
