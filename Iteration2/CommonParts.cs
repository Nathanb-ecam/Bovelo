using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class CommonParts
    {
        private List<string> composant_nbre1 = new List<string>() {"bequille","kit de frein","kit vitesse", "kit pedalier", "cassette de pignons", "chaine", "dérailleur", "disque frein", "guidon", "plateau", "selle"};
        private List<string> composant_nbre2 = new List<string>() { "chambre a air", "disque de frein" };
        private List<string> composant_nbre4 = new List<string>() { "catadioptre" };

        public CommonParts()
        {            

        }
        public List<string> getList_Nbr1()
        {
            return composant_nbre1;
        }

        public List<string> getList_Nbr2()
        {
            return composant_nbre2;
        }
        public List<string> getList_Nbr4()
        {
            return composant_nbre4;
        }
    }
}
