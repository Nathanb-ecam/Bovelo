using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Monteur
    {
        string test0;

        private string nameMonteur;
        private string identif2;

        private List<string> ourMonteurs = new List<string>();
        private Dictionary<string, string> Identification = new Dictionary<string, string>();

        private bool checkUp;

        public string getMonteur { get { return nameMonteur; } set { test0 = value; } }

        public Monteur(string a)
        {
            this.nameMonteur = a;
            addMonteur(a);
        }

        public Monteur(string a , string b)
        {
            this.nameMonteur = a;
            this.identif2 = b;

        }

        public bool checkIdentif()
        {
            foreach (KeyValuePair<string, string> test in Identification)
            {
                if (test.Key == nameMonteur && test.Value == identif2)
                {
                    checkUp = true;
                }
                else
                {
                    checkUp = false;
                }
            }
            return checkUp;

        }

        public void addMonteur(string a)
        {
            ourMonteurs.Add(a);
        }
    }
}
