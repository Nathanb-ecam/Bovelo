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
        /*private static Dictionary<string, string> bikeDict = new Dictionary<string,string>();
        
        public Catalog()
        {
            // on ajoute les liens des photos
            // les 3 vélo city
            bikeDict.Add("CR", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/rougeVille.png");
            bikeDict.Add("CB", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/bleuVille.jpg");
            bikeDict.Add("CG", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Ville/vertVille.jpg");
            // les 3 velo adventure 
            bikeDict.Add("AR", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttRouge.jpg");
            bikeDict.Add("AB", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttBleu.jpg");
            bikeDict.Add("AG", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Adventure/vttNoir.jpg");
            // les 3 velo explorer 
            bikeDict.Add("ER", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcRouge.jpg");
            bikeDict.Add("EB", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcBleu.jpg");
            bikeDict.Add("EG", "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcNoir.jpg");

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
                //bikeDict[key] = img;
            }
        }
        public string getValue(string key)
        {
            return bikeDict[key];
        }
        public Dictionary<string,string> getDico // on cherche a obtenir un dictionnaire trier par modeles
        {

            get { return bikeDict; }
        }*/









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
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Red"), 200,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcRouge.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Blue"), 200,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcBleu.jpg");
            bikeDict.Add(new Bike(new Type("Explorer"), new Size(26), new Color("Green"), 200,false), "C:/Users/nathanbuchin/Desktop/BAC3/Software2/boveloPictures/Explorer/vtcNoir.jpg");
        }
        public void addBike(Bike b, string img)
        {
            // pour vérifier si la clé existe déja dans le dico
            if (!bikeDict.ContainsKey(b))
            {
                bikeDict.Add(b, img);
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
