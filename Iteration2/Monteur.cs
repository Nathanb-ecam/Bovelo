using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Monteur
    {
        private string nameMonteur;
        private List<string> ourMonteurs = new List<string>();
        
        public Monteur(string a)
        {
            this.nameMonteur = a;
        }

        public void addMonteur(string a)
        {
            ourMonteurs.Add(a);
        }
    }
}
