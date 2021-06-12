using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class AdventureParts
    {
        private List<string> composant_nbre1 = new List<string>() { "cadre renforce" };
        private List<string> composant_nbre2 = new List<string>() { "pneu large" };        

        public List<string> getList_Nbr1()
        {
            return composant_nbre1;
        }

        public List<string> getList_Nbr2()
        {
            return composant_nbre2;
        }        
    }
}
