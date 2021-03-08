using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Order
    {
        private Dictionary<Bike, List<int>> bikes;
        private List<Bike> bikes_list = new List<Bike>();
        private static int id =0;
        public Order(Dictionary<Bike, List<int>> bikes)
        {
            id++;
            this.bikes = bikes;
        }
        public Dictionary<Bike, List<int>> Bikes
        {
            get { return bikes; }
        }

        public void AddBike(Bike bike)
        {
            bikes_list.Add(bike);
            if (!bikes.ContainsKey(bike))
            {
                List<int> l = new List<int>();
                l.Add(1);
                l.Add(bike.Type.Price);
                bikes[bike] = l;
            }
            else
            {
                bikes[bike][0] += 1;
                bikes[bike][1] += bike.Type.Price;
            }
        }

        public int GetNumBike(Type type)
        {
            int num = 0;
            foreach (KeyValuePair<Bike, List<int>> bike in bikes)
            {
                if (bike.Key.Type.Types == type.Types)
                {
                    num += 1;
                }
            }
            return num;
        }

        public override string ToString()
        {
            return String.Format("{0}", id);
        }
    }

}
