using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Part
    {
        private int nombreGuidon;
        private int nombreChassis;
        private int nombreRoue;
        private int béquille;
        private int kitFrein;
        private int kitVitesse;
        private int cadre;
        private int pédalier; 
        //private int pignons;
        //private int catadioptre;
        //private int chaîne;
        //private int garde_boue;


        private string location;

        Random r = new Random();

        public Part(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            nombreGuidon = a;
            nombreChassis = b;
            nombreRoue = c;
            d = this.béquille;
            e = this.kitFrein;
            f = this.kitVitesse;
            g = this.cadre;
            h = this.pédalier;
            //i = this.pignons;
            //j = this.catadioptre;
            //k = this.chaîne;
            //l = this.garde_boue;


            location = String.Format("E{0}", r.Next());
        }

        public int getNombreChassis()
        {
            return nombreChassis;
        }
        public int getnombreGuidon()
        {
            return nombreGuidon;
        }
        public int getnombreRoue()
        {
            return nombreRoue;
        }
        public int getbéquille()
        {
            return béquille;
        }
        public int getkitFrein()
        {
            return kitFrein;
        }
        public int getkitVitesse()
        {
            return kitVitesse;
        }
        public int getcadre()
        {
            return cadre;
        }

        public int getpédalier()
        {
            return pédalier;
        }



        public string getLocation()
        {
            return location;
        }
    }
}
