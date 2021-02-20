using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Order
    {
        private readonly int id;
        private Dictionary<Bike, int> bikes;

        public Order(int id, Dictionary<Bike, int> bikes)
        {
            this.id = id;
            this.bikes = bikes;
        }

        public void AddBike(Bike bike, int number)
        {
            bikes.Add(bike, number);
        }

        public int GetNumBike(Type type)
        {
            int num = 0;
            foreach (KeyValuePair<Bike, int> bike in bikes)
            {
                if (bike.Key.Type == type)
                {
                    num = bikes[bike.Key];
                }
            }
            return num;
        }

        public override string ToString()
        {
            foreach (KeyValuePair<Bike, int> bike in bikes)
            {
                Console.WriteLine(bike.Key.ToString(), bike.Value);
            }
            return String.Format("{0}", this.id);
        }
    }

}
