using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bovelo
{
    public class Bike
    {
        
        private Type type;
        private Size size;
        private Color color;
        private Parts partsList;
        private double price;
        private bool increment; // pour choisir si il faut incrementer l'id ou pas 
        private static int id = 0;

        //Constructor
        public Bike(Type type, Size size, Color color,double price, bool i)
        {
            this.increment = i;
            this.price = price;
            this.type = type;
            this.color = color;
            this.size = size;
            if (i == true)
            {
                id++;
            }
        }

        public int IdBike
        {
            get { return id; }
            set { id = value; }
        }

        public Type Type
        {
            get { return type; }
        }
        public Color Color
        {
            get { return color; }
        }

        public Size Size
        {
            get { return size; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
