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
            generateCatalog();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void orderBikeBuilder(Type model, Size size, Color color, int quantity)
        {

            for (int value= 0; value < quantity; value++)
            {
                Bike bike_name = new Bike(model,size,color,model.Price);
                order.AddBike(bike_name);          
            }
            
        }
             
        private void recapBtn_Click(object sender, EventArgs e)
        {
            panelRecap.Visible = true;
            panelOrder.Visible = false;
            panelDelay.Visible = false;
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

        private void orderPageBtn_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;
            panelDelay.Visible = false;
            panelRecap.Visible = false;
            panelCatalog.Visible = false;
        }


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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            order.Bikes.Clear();
            totalPriceTxt.Text = "";
            recapTxt.Text = "";
        }

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

        private void generateCatalog()
        {
            Dictionary<string, string> bikeDict = c.getDico;
            int count = 0; //pour compter les itérations, apres 3 photos on passe a la ligne
            int x =250; // x et y pour positionner le poin de départ des picturebox
            int y = 65;
            int n = 1; // index pour determiner le label a ecricre 
            int a = 5; // a et b pour positionner les labels correspondants aux photos
            int b = 150;
            foreach(KeyValuePair<string, string> item in bikeDict)
            {
                
                Console.WriteLine(item.Key); // CR 
                Console.WriteLine(item.Value);// lien velo city rouge
                //if (item.Key == "CR" || item.Key=="CB" || item.Key == "CG")
                //{
                    if (count < 3 && item.Key.Substring(0,1)=="C")
                    { 
                        // on genere une image du vélo 
                        PictureBox_generator(x,y,item.Value, "City a 100euros");
                        if (n == 1)
                        {
                            //Label_generator("City a 100euros",a,b);
                            n++;
                        }
                        x += 250;
                        count++;
                    }
                    
                    else if (count > 2 && count <6 && item.Key.Substring(0, 1) == "A")
                    {
                    
                    // on remet le compteur au point de départ
                        y = 245;
                    
                        PictureBox_generator(x-750, y, item.Value, "Adventure a 150euros");
                        x += 250;
                        if (n == 2)
                        {
                            //Label_generator("Adventure a 150euros",a,b+150);
                            n++;
                        } 
                        count++;
                    }
                    else if (count >5 && count<9 && item.Key.Substring(0, 1) == "E")
                    {  
                        y = 400;
                    Console.WriteLine(x); // il vaut 1000 puis 1250 puis 1500
                    PictureBox_generator(x-1500, y, item.Value, "Explorer a 200euros");
                        x += 250;
                        if (n == 3)
                        {
                            //Label_generator("Explorer a 200euros", a, b+300);
                            n++;
                        }
                        count++;
                    }
                    
                //}

            }
            

        }
/*        private void Label_generator(string name, int x , int y)
        {
            Label l = new Label();
            panelCatalog.Controls.Add(l);
            l.AutoSize = true;
            l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            l.Font = new System.Drawing.Font("EuroRoman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            l.Location = new System.Drawing.Point(x, y);
            l.Size = new System.Drawing.Size(212, 29);
            l.Name = name; 
            l.Text = name;
        }*/
        private void PictureBox_generator(int x, int y,string imageLink, string name)
        {
            PictureBox box = new PictureBox();
            box.Click+=new EventHandler(this.box_Click);
            panelCatalog.Controls.Add(box);
            box.Location = new System.Drawing.Point(x, y);
            box.Size = new System.Drawing.Size(198, 136);
            box.Name = name;
            box.SizeMode = PictureBoxSizeMode.Zoom;
            box.Image = new Bitmap(imageLink);
            //Label_generator(name, x-25, y-25);

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void box_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Image has been pressed");
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            
            string re = modelBox.Text.Substring(0, 1) + colorBox.Text.Substring(0,1);
            Console.WriteLine(modelBox.Text);
            string imageLink = c.getValue(re); // besoin de manipuler l'instance de la classe catalog !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                                                                                          // alors il faut afficher le vélo correspondant
            Bitmap bm = new Bitmap(imageLink);
            previewBox.SizeMode = PictureBoxSizeMode.Zoom;
            previewBox.Image = bm;

        }
    }
}
