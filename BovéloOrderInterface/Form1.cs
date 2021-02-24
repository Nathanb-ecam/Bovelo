using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bovelo
{
    public partial class Form1 : Form
    {
     
        Order order = new Order(new Dictionary<string, List<int>>());
        Catalog c = new Catalog();

        public Form1()
        {
            InitializeComponent();
            modelBox.SelectedIndex = 0;
            sizeBox.SelectedIndex = 0;
            colorBox.SelectedIndex = 0;
            quantityBox.SelectedText = "1";
            NewGen_Catalog();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        // pour instancier autant de velo que le client renseigne dans la case quantity
        private void orderBikeBuilder(Type model, Size size, Color color, int quantity)
        {
            for (int value= 0; value < quantity; value++)
            {
                Bike bike_name = new Bike(model,size,color,model.Price,true);
                order.AddBike(bike_name);          
            } 
        }
             
        // les 3 fonctions qui suivent servent juste a determiner la page active
        private void recapBtn_Click(object sender, EventArgs e)
        {
            panelRecap.Visible = true;
            panelOrder.Visible = false;
            panelDelay.Visible = false;
            panelCatalog.Visible = false;
        }
        private void orderPageBtn_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;
            panelDelay.Visible = false;
            panelRecap.Visible = false;
            panelCatalog.Visible = false;
        }

        private void delayBtn_Click(object sender, EventArgs e)
        {
            panelDelay.Visible = true;
            panelOrder.Visible = false;
            panelRecap.Visible = false;
            panelCatalog.Visible = false;
            // chercher dans la bdd si vélo en stock puis estimer delay
            //delayEstimater();
   
        }

        // pour ajouter les elements selectiones dans commande
        private void addBtn_Click(object sender, EventArgs e)
        {
            string recap = "";
            int totalPrice = 0;
            string model = modelBox.Text;
            string size = sizeBox.Text;
            string color = colorBox.Text;
            int bikeSize = Int32.Parse(size.Substring(0,2));
            int quantity = Int32.Parse(quantityBox.Text);

            Type t = new Type(model);
            Color c = new Color(color);
            Size s = new Size(bikeSize);

            if (model== "Adventure" || model == "Explorer" || model == "City")
            {
                orderBikeBuilder(t,s,c,quantity);
            }

            foreach (KeyValuePair<string, List<int>> bike in order.Bikes)
            {         
                recap += String.Format("{0} {1} piece(s) {2}$\n", bike.Key, bike.Value[0], bike.Value[1]);
                totalPrice += bike.Value[1];
            }

            totalPriceTxt.Text = totalPrice.ToString();
            recapTxt.Text = recap;
            
        }

        // pour vider le panier et recommencer une commande 
        private void resetBtn_Click(object sender, EventArgs e)
        {
            order.Bikes.Clear();
            totalPriceTxt.Text = "";
            recapTxt.Text = "";
        }

        // pour confirmer une commande 
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(order.Bikes.Count != 0)
            {
                Customer customer = new Customer("FrigoFri");
                customer.SetOrder(order);
                Console.WriteLine(customer.ToString());
                order.Bikes.Clear();
                totalPriceTxt.Text = "";
                recapTxt.Text = "";
            }
            else
            {
                Console.WriteLine("Please choose articles first :)");
            }

            // doit retirer la commande de la bdd
        }

        private void catalogBtn_Click(object sender, EventArgs e)
        {
            panelCatalog.Visible = true;
            panelOrder.Visible = false;
            panelDelay.Visible = false;
            panelRecap.Visible = false;
        }
        


        // fonction qui va générer le contenu de la page catalogue de manière dynamique
        private void NewGen_Catalog()
        {
            int x = 200;
            int y;
            int n = 0;
            int i =1;
            int nbr = 3;

            foreach (KeyValuePair<Bike, string> item in c.getDico)
            {
                if (n < nbr)
                {
                    i = 0;  
                }
                else if(n>= nbr && n < 2*nbr)
                {
                    i = 1;
                }
                else if (n >= 2*nbr && n < 3*nbr)
                {
                    i = 2;
                }
                else if (n>=3*nbr && n < 4*nbr)
                {
                    i = 3;
                }
                y = 255 * 3*i/4;
                PictureBox_generator(x - (nbr * 245 * i), y+75, item.Value, "picture" + n);
                x += 250;
                n += 1;
            }
        }

        // fonction qui permet de creer un espace pour mettre une image dans le panel Catalog
        private void PictureBox_generator(int x, int y,string imageLink, string name)
        {
            PictureBox box = new PictureBox();
            box.Click+=new EventHandler(this.box_Click);
            panelCatalog.Controls.Add(box);
            box.Location = new System.Drawing.Point(x, y);
            box.Size = new System.Drawing.Size(180, 126);
            box.Name = name;
            box.SizeMode = PictureBoxSizeMode.Zoom;
            box.Image = new Bitmap(imageLink);

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // fonction qui est executee lorsqu'on clique sur une image du catalogue
        private void box_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine("Image has been pressed");
            //MessageBox.Show("Comportement a ajouter");
            // Faire un popup qui affiche le modele, la couleur et le prix 

        }

        //pour recuperer le model selectionnee par l'utilisateur
        private Type Detect_Model(string model)
        {
            Type t;
            switch (model) // pour recuperer le model
            {
                case "C":
                    t = new Type("City");
                    break;
                case "A":
                    t = new Type("Adventure");
                    break;
                case "E":
                    t = new Type("Explorer");
                    break;
                default:
                    t = new Type("City");
                    break;
            }

            return t;
        }
        
        // pour recuperer la couleur selectionnee par l'utilisateur
        private Color Detect_Color(string color)
        {
            Color col;
            switch (color) 
            {
                case "R":
                    col = new Color("Red");
                    break;
                case "B":
                    col = new Color("Blue");
                    break;
                case "G":
                    col = new Color("Green");
                    break;
                default:
                    col = new Color("Red");
                    break;
            }
            return col;
        }
        // genere une image "preview" dans la page de commande en fonction des choix selectionnés
        private void previewBtn_Click(object sender, EventArgs e)
        {
            string m = modelBox.Text.Substring(0, 1);
            string color = colorBox.Text.Substring(0, 1);
            Type t = Detect_Model(m);
            Color col = Detect_Color(color);
            string imageLink = "Images/rougeVille.png";

            foreach (KeyValuePair<Bike, string> item in c.getDico)
            {
                if (item.Key.Type.Types == t.Types && item.Key.Color.Colors == col.Colors)
                {
                    imageLink = item.Value;
                }
                Bitmap bm = new Bitmap(imageLink);
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                previewBox.Size = new System.Drawing.Size(300, 300);
                previewBox.Location = new System.Drawing.Point(425, 15);
                previewBox.Image = bm;
            }
        }
    }
}
