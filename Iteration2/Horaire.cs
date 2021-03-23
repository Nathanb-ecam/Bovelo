using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Horaire
    {
        string test0;

        string horaireTache0;
        string dureeTache0;

        Détail_et_modification m2 = new Détail_et_modification();

        public string HoraireTache { get { return horaireTache0;  } set { test0 = value; } }
        public string DureeTache { get { return dureeTache0; } set { test0 = value; } }

        public Horaire(string a, string b)
        {
            this.horaireTache0 = a;
            this.dureeTache0 = b;
        }

        public string getHoraire(int b)
        {
            test0 = m2.HoraireTache + " " + b.ToString();
            return test0;
        }




    }
}
