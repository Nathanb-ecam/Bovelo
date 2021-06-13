using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class SizeParts
    {
        //The componants that are common to all bikes but differanciate by their size

        private List<string> composant_nbre1 = new List<string>() { "fourche" };
        private List<string> composant_nbre2 = new List<string>() { "roue" };

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
