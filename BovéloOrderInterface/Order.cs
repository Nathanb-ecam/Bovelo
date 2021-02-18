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

        public string AddBike(Bike bike, int number)
        {
            bikes.Add(bike, number);
            String s = String.Format("You added {0} of {1}", number,bike) ;
            return s;
        }

        public int GetNumBike(Bike bike)
        {
            return this.bikes[bike];
        }

        public override string ToString()
        {
            return String.Format("{0}", this.id);
        }
    }

}
