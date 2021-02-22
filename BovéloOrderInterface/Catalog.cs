using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Catalog
    {
        private List<Bike> bikeList = new List<Bike>();

        public void addBike(Bike bike)
        {
            this.bikeList.Add(bike);
        }

        public void removeBike(Bike bike)
        {
            this.bikeList.Remove(bike);
        }
    }
}
