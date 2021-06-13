using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class ExplorerParts

        //components of type explorer

    {
        private List<string> composant_nbre1 = new List<string>() { "cadre", "garde boue large" };
        private List<string> composant_nbre2 = new List<string>() { "pneu large" };
        private List<string> composant_nbre1_sansCouleurType = new List<string>() { "eclairage", "porte bagage" };

        public List<string> getList_Nbr1()
        {
            return composant_nbre1;
        }

        public List<string> getList_Nbr2()
        {
            return composant_nbre2;
        }

        public List<string> getList_Nbr1_SSCT()
        {
            return composant_nbre1_sansCouleurType;
        }


    }
}
