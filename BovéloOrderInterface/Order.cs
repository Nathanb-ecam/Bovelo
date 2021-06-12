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
        private Dictionary<String, int> regroupedBikesDict = new Dictionary<string, int>(){ }; //{ "Type,Color,Size": Quantity}

        private List<Bike> bikes_list = new List<Bike>();
        private static int id =0;
        private Agent order_agent;
        private Customer customer;

        public Order(Dictionary<Bike, List<int>> bikes)
        {
            id++;
            this.bikes = bikes;
        }
        public Dictionary<Bike, List<int>> Bikes
        {
            get { return bikes; }
        }

        public Customer Customer
        {
            get { return customer; }
        }
        public void SetCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public List<Bike> Bikes_list
        {
            get { return bikes_list; }
        }

        public void Add_Agent(Agent agent)
        {
            order_agent = agent;
        }

        public void AddBike(Bike bike)
        {
            bikes_list.Add(bike);
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(bike.Type.Price);
            bikes[bike] = l;

            string infoBike = String.Format("{0},{1},{2}", bike.Type.Types, bike.Size.Sizes, bike.Color.Colors);
            
            if (regroupedBikesDict.ContainsKey(infoBike))
            {
                regroupedBikesDict[infoBike] += 1;
            }
            else
            {
                regroupedBikesDict[infoBike] = 1;
            }
            
            
        }

        public void reset()
        {
            bikes.Clear();
            bikes_list.Clear();
            regroupedBikesDict.Clear();
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
        public Dictionary<String, int> RegroupedBikesDict
        {
            get { return regroupedBikesDict; }
        }
    }

}
