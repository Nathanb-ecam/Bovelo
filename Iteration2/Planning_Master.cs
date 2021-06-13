using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Planning_Master
    {
        //This PlanningMaster class makes it possible to know who is connected as a manager

        private string identf1;
        private string password;

        private List<string> ManagersConnected = new List<string>();

        public Planning_Master(string a, string b)
        {
            this.identf1 = a;
            this.password = b;
            ManagersConnected.Add(a);
        }    
    }
}
