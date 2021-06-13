using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class AdventureParts
        //Componants of type adventure
    {
        private List<string> composant_nbre1 = new List<string>() { "cadre renforce" }; //in quantity of use 1
        private List<string> composant_nbre2 = new List<string>() { "pneu large" };     //in quantity of use 2

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
