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
using System.Resources;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Bovelo
{
    public partial class Form1 : Form
    {
        Agent agent = new Agent("Khaled",1,"07","Vilvoorde");
        Order order = new Order(new Dictionary<Bike, List<int>>());
               
        Catalog c = new Catalog();
        MySqlConnection cn = new MySqlConnection("server=193.191.240.67;user=nick;database=mydb;port=63307;password=1234");

        public Form1()
        {
            InitializeComponent();
            
            modelBox.SelectedIndex = 0;
            priceLabel.Text = 100.ToString();
            sizeBox.SelectedIndex = 0;
            colorBox.SelectedIndex = 0;
            quantityBox.SelectedText = "1";
            // si on souhaite ajouter un velo different
            c.addBike(new Bike(new Type("Electric"), new Size("26"), new Color("Black"), 100, false), "C:/Users/nathanbuchin/Pictures/Ville/CityRed.png");
            c.addBike(new Bike(new Type("City"), new Size("26"), new Color("Red"), 100, false), "C:/Users/nathanbuchin/Pictures/Ville/CityRed.png");
            NewGen_Catalog();
            panelCatalog.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Price_Changed();
        }
        private void Price_Changed()
        {
            int price = 0;
            if (quantityBox.Text != "")
            {
                if (modelBox.Text == "City")
                {
                    price = 100 * Int32.Parse(quantityBox.Text);
                }
                else if (modelBox.Text == "Adventure")
                {
                    price = 200 * Int32.Parse(quantityBox.Text);
                }
                else if (modelBox.Text == "Explorer")
                {
                    price = 150 * Int32.Parse(quantityBox.Text);
                }
                priceLabel.Text = price.ToString();
            }

        }
        private void quantityBox_TextChanged(object sender, EventArgs e)
        {
            Price_Changed();
        }

        // pour instancier autant de velo que le client renseigne dans la case quantity
        private void orderBikeBuilder(Type model, Size size, Color color, int quantity)
        {
            for (int value = 0; value < quantity; value++)
            {
                Bike bike_name = new Bike(model, size, color, model.Price, true);
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
            panel1.Visible = false;
        }
        private void orderPageBtn_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;
            panelDelay.Visible = false;
            panelRecap.Visible = false;
            panelCatalog.Visible = false;
            panel1.Visible = false;
        }

        private void delayBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> bikesCounter = new Dictionary<string, int>(){ };

            panelDelay.Visible = true;
            panelOrder.Visible = false;
            panelRecap.Visible = false;
            panel1.Visible = false;
            panelCatalog.Visible = false;
            // chercher dans la bdd si vélo en stock puis estimer delay
            //delayEstimater();



            List<string> commonParts = new List<string>(){"béquille","kitFrein","kitVitesse","kitPédalier","casetteDePignons","catadioptre","chaîne","chambreàAir","dérailleur","disqueDeFrein","fourche","guidon","plateau","roue","selle"};
            List<string> city_Extra_Parts = new List<string>(){"cadre","pneu","garde-boue","porte-Bagage","éclairage"};
            List<string> expl_Extra_Parts = new List<string>(){"cadre","pneuLarge","garde-boueLarge","porte-Bagage","éclairage"};
            List<string> adv_Extra_Parts = new List<string>(){"cadreRenforcé","pneuLarge"};
            // pieces a verifier dans le stock
            Dictionary<Bike, List<int>> orderedBikes = order.Bikes;
            // il faut regarder le modele et la taille des velo de la commande puis regarder s'il y a assez de pieces dans le stock 
            
            // boucle pour reordonner le dictionnaire
            foreach (KeyValuePair<Bike, List<int>> bike in orderedBikes)
            {
                string b = bike.Key.Type.Types + bike.Key.Color.Colors + bike.Key.Size.Sizes;
                
                if (!bikesCounter.ContainsKey(b))
                {
                    bikesCounter.Add((b), bike.Value[0]);
                }
                else
                {
                    bikesCounter[b] += bike.Value[0];
                }     
            }


             foreach (KeyValuePair<string, int> bike in bikesCounter)
            {
                int number = bike.Value;
                if (bike.Key.Substring(0,3) =="Cit")
                {
                    Console.WriteLine("dkljfeq");
                }
            }
            
        }

        // pour ajouter les elements selectiones dans commande
        private void addBtn_Click(object sender, EventArgs e)
        {
            string model = modelBox.Text;
            string size = sizeBox.Text;
            string color = colorBox.Text;
            string bikeSize = size.Substring(0, 2);
            int quantity = Int32.Parse(quantityBox.Text);

            Type t = new Type(model);
            Color c = new Color(color);
            Size s = new Size(bikeSize);
            if (model == "Adventure" || model == "Explorer" || model == "City")
            {
                orderBikeBuilder(t, s, c, quantity);
            }
            generate_Recap();

        }
        private void generate_Recap()
        {
            string recap = "";
            int totalPrice = 0;
            Dictionary<string, int> bikesCounter = new Dictionary<string, int>(){ };
            Dictionary<Bike, List<int>> orderedBikes = order.Bikes;

            // boucle pour reordonner le dictionnaire
            foreach (KeyValuePair<Bike, List<int>> bike in orderedBikes)
            {
                string b = bike.Key.Type.Types + bike.Key.Color.Colors + bike.Key.Size.Sizes;
                
                if (!bikesCounter.ContainsKey(b))
                {
                    bikesCounter.Add((b), bike.Value[0]);
                }
                else
                {
                    bikesCounter[b] += bike.Value[0];
                }     
            }

            // on parcourir le dictionnaire trier pour afficher le recap
            foreach (KeyValuePair<string, int> bike in bikesCounter)
            {
                if (bike.Key.Substring(0, 3) == "Cit")
                {
                    totalPrice += (bike.Value * 100);
                }
                else if (bike.Key.Substring(0, 3) == "Adv")
                {
                    totalPrice += (bike.Value * 200);
                }
                else if (bike.Key.Substring(0, 3) == "Exp")
                {
                    totalPrice += (bike.Value * 150);
                }
                if (bike.Value != 0)
                {
                    recap += String.Format("Vélo : {0}, quantité : {1} piece(s) \n", bike.Key, bike.Value);
                }
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
        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
           
            DateTime dt = DateTime.Now;
            dt.AddDays(3);                                      //We add 3 days of delay to the order in the best case.
            if (cn.State == ConnectionState.Closed) { cn.Open(); };
            if (order.Bikes.Count != 0)
            {
                Customer customer = new Customer(nameBox.Text, phoneBox.Text, adressBox.Text);
                //Customer customer = new Customer("Yann","07","Nick");
                string cust_phone = customer.Phone;
                string cust_id = "0";
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Customer WHERE Phone = {0}",cust_phone), cn);
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                if (data.Rows.Count != 0)
                {
                    foreach(DataRow row in data.Rows)
                    {
                        cust_id = (row["idCustomer"]).ToString();
                    }

                }
                else
                {
                    MySqlCommand cmd0 = new MySqlCommand("INSERT INTO Customer(Name,Phone,Adress) VALUES (@name,@phone,@adress)", cn);
                    cmd0.Parameters.AddWithValue("@name", customer.Name);
                    cmd0.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd0.Parameters.AddWithValue("@adress", customer.Adress);
                    cmd0.ExecuteNonQuery();
                    cust_id = cmd0.LastInsertedId.ToString();
                }

                order.SetCustomer(customer);
                order.Add_Agent(agent);                         //We associate an agent for our order.
                foreach (Bike bike in order.Bikes_list)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Bike(Color,Type,Size,Assembler_idAssembler,Price) VALUES (@color,@type,@size,@id_assembler,@price)", cn);
                    cmd.Parameters.AddWithValue("@color", bike.Color.Colors);
                    cmd.Parameters.AddWithValue("@type", bike.Type.Types);
                    cmd.Parameters.AddWithValue("@size", bike.Size.Sizes);
                    cmd.Parameters.AddWithValue("@price", bike.Type.Price);
                    cmd.Parameters.AddWithValue("@id_assembler", 1);
                    cmd.ExecuteNonQuery();
                }
                //MySqlCommand cmd2 = new MySqlCommand("INSERT INTO Order(Price,BikesQuantity,Delay,Customer_idCustomer,Agent_idAgent) VALUES (@total_price,@quantity,@delay,@id_customer,@id_agent)", cn);
                //cmd2.Parameters.AddWithValue("@total_price", Int32.Parse(totalPriceTxt.Text));
                //cmd2.Parameters.AddWithValue("@quantity", (order.Bikes_list).Count);
                //cmd2.Parameters.AddWithValue("@delay", 1);
                //cmd2.Parameters.AddWithValue("@id_customer", cust_id);
                //cmd2.Parameters.AddWithValue("@id_agent", agent.Id);
                //cmd2.ExecuteNonQuery();
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
            FlowLayoutPanel fp = new FlowLayoutPanel();
            fp.Location = new System.Drawing.Point(200, 50);
            fp.Size = new System.Drawing.Size(1105, 658);
            fp.FlowDirection = FlowDirection.LeftToRight;
            fp.AutoScroll = true;
            panelCatalog.Controls.Add(fp);

            foreach (KeyValuePair<Bike, string> item in c.getDico)
            {
                // panel qui va contenir une image et un bouton 
                Panel p = new Panel();
                p.Size = new System.Drawing.Size(400, 350);//250, 150
                p.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);


                //bouton pour aller a la page de commande du velo
                Button btn = new Button();
                btn.Click += new EventHandler(this.btn_Click);
                btn.Name = item.Key.Type.Types +'/'+ item.Key.Color.Colors; //Le Name contient le modele et la couleur 
                btn.Size = new System.Drawing.Size(400, 75);
                btn.Text = "Order me";
                btn.Font = new Font("EuroRoman", 12.5f);
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 240, 200);
                btn.BackColor = System.Drawing.Color.FromArgb(114, 140, 170);

                //image du velo
                PictureBox b = new PictureBox();
                Console.WriteLine(item.Value);
                b.Image = new Bitmap(item.Value);
                b.SizeMode = PictureBoxSizeMode.Zoom;
                b.Size = new System.Drawing.Size(375, 225);
                b.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
               

                // on ajoute le bouton et l'image dans le panel
                p.Controls.Add(b);
                b.Dock = DockStyle.None;
                p.Controls.Add(btn);
                btn.Dock = DockStyle.Bottom;

                //on ajoute le panel actuel au FLowPanel
                fp.Controls.Add(p);

            }
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // fonction qui est executee lorsqu'on clique sur une image du catalogue
        private void btn_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;
            string bikeRef = (sender as Button).Name;
            string[] elems = bikeRef.Split(new char[] { '/' });
            modelBox.SelectedItem = elems[0];
            colorBox.SelectedItem = elems[1];
        }


       


        private void panelRecap_Paint(object sender, PaintEventArgs e)
        {

        }
       private void confirmBtn_Click(object sender, EventArgs e)
       {
           panel1.Visible = true;
       }
    }
}
