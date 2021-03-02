using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bovelo
{
    public class Catalog
    {
        private static Dictionary<Bike, string> bikeDict = new Dictionary<Bike, string>();

        public Catalog()
        {

            bikeDict.Add(new Bike(new Type("City"), new Size(26), new Color("Red"), 100,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/rougeVille.png");
            bikeDict.Add(new Bike(new Type("City"), new Size(26), new Color("Blue"), 100,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/bleuVille.jpg");
            bikeDict.Add(new Bike(new Type("City"), new Size(26), new Color("Green"), 100,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/vertVille.jpg");
            // les 3 velo adventure 
            bikeDict.Add(new Bike(new Type("Adventure"), new Size(26), new Color("Red"), 150,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttRouge.jpg");
            bikeDict.Add(new Bike(new Type("Adventure"), new Size(26), new Color("Blue"), 150,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttBleu.jpg");
            bikeDict.Add(new Bike(new Type("Adventure"), new Size(26), new Color("Green"), 150,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttNoir.jpg");
            // les 3 velo explorer 
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Red"), 200, false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcRouge.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Blue"), 200, false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcBleu.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Green"), 200, false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcNoir.jpg");
            
        }
        public void addBike(Bike b, string img)
        {
            foreach (KeyValuePair<Bike, string> item in bikeDict)
            {
                if (!(item.Key.Type.Types == b.Type.Types && item.Key.Color.Colors == b.Color.Colors))
                {

                    Console.WriteLine(String.Format("Un velo de type {0} et de couleur {1} a été ajouté au catalogue",b.Type.Types,b.Color.Colors));
                    bikeDict.Add(b, img);
                    break; 
                }
                else
                {
                    Console.WriteLine("Ce modele se trouve deja dans le catalogue");
                    break;
                }
            }
        }
        public string getValue(Bike b)
        {
            return bikeDict[b];
        }
        public Dictionary<Bike, string> getDico // on cherche a obtenir un dictionnaire trier par modeles
        {

            get { return bikeDict; }
        }








    }
}
