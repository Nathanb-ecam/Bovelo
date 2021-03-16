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

        Détail_et_modification m2 = new Détail_et_modification();

        public string Horaire1 { get { return m2.HoraireTache + " " + m2.DureeTache;  } set { test0 = value; } }



        public string getHoraire()
        {
            test0 = m2.HoraireTache + " " + m2.DureeTache;
            return test0;
        }

        private void timer1_Tick(int a)
        {
            a -= 1;
        }

    }
}
