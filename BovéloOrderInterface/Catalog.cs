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

            bikeDict.Add(new Bike(new Type("City"), new Size("26"), new Color("Red"), 100,false), "C:/Users/nathanbuchin/Pictures/Ville/CityRed.png");
            bikeDict.Add(new Bike(new Type("City"), new Size("26"), new Color("Blue"), 100,false), "C:/Users/nathanbuchin/Pictures/Ville/CityBlue.jpg");
            bikeDict.Add(new Bike(new Type("City"), new Size("26"), new Color("Black"), 100,false), "C:/Users/nathanbuchin/Pictures/Ville/CityBlack.jpg");
            // les 3 velo adventure 
            bikeDict.Add(new Bike(new Type("Adventure"), new Size("26"), new Color("Red"), 150,false), "C:/Users/nathanbuchin/Pictures/Adventure/AdventureRed.jpg");
            bikeDict.Add(new Bike(new Type("Adventure"), new Size("26"), new Color("Blue"), 150,false), "C:/Users/nathanbuchin/Pictures/Adventure/AdventureBlue.jpg");
            bikeDict.Add(new Bike(new Type("Adventure"), new Size("26"), new Color("Black"), 150,false), "C:/Users/nathanbuchin/Pictures/Adventure/AdventureBlack.jpg");
            // les 3 velo explorer 
            bikeDict.Add(new Bike(new Type("Explorer"), new Size("26"), new Color("Red"), 200, false), "C:/Users/nathanbuchin/Pictures/Explorer/ExplorerRed.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size("26"), new Color("Blue"), 200, false), "C:/Users/nathanbuchin/Pictures/Explorer/ExplorerBlue.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size("26"), new Color("Black"), 200, false), "C:/Users/nathanbuchin/Pictures/Explorer/ExplorerBlack.jpg");
            
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
