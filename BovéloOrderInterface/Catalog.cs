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
        private static Dictionary<string, string> bikeDict = new Dictionary<string,string>();
        
        public Catalog()
        {
            // on ajoute les liens des photos
            bikeDict.Add("CR", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/rougeVille.png");
            bikeDict.Add("CB", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/bleuVille.jpg");
            bikeDict.Add("CG", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/vertVille.jpg");
            
        }
        public void addBike(string key,string img)
        {
            // pour vérifier si la clé existe déja dans le dico
            if (!bikeDict.ContainsKey(key))
            {
                bikeDict.Add(key, img);
            }
            else
            {
                bikeDict[key] = img;
            }
        }
        public string getValue(string key)
        {
            return bikeDict[key];
        }
        public Dictionary<string,string> getDico
        {
            get { return bikeDict; }
        }

/*        public void removeBike(Bike bike)
        {
            bikeDict.Remove(bike);
        }*/
    }
}
