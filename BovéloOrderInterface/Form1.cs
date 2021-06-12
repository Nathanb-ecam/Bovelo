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
using System.Data.SqlClient;


namespace Bovelo
{
    public partial class Form1 : Form
    {
        Agent agent;
        Order order = new Order(new Dictionary<Bike, List<int>>());
        Customer customer;

        int delay;

        DataTable stockTable = new DataTable();
        DataTable cityTable = new DataTable();
        DataTable explorerTable = new DataTable();
        DataTable adventureTable = new DataTable();
        DataTable partsToOrderTable = new DataTable();

        Catalog c= new Catalog(Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName);

        MySqlConnection cn = new MySqlConnection("server=193.191.240.67;user=nick;database=mydb;port=63307;password=1234");

        public Form1()
        {
            InitializeComponent();

            modelBox.SelectedIndex = 0;
            priceLabel.Text = 100.ToString();
            sizeBox.SelectedIndex = 0;
            colorBox.SelectedIndex = 0;
            quantityBox.SelectedText = "1";
            NewGen_Catalog();
            panelCatalog.Visible = true;
            panelRecap.Visible = false;
            panelOrder.Visible = false;
            panel1.Visible = false;

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Price_Changed();
        }
        private void Price_Changed()
        {
            int price = 0;
            try
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
            catch
            {
                Console.WriteLine("Format incorect");
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
        
        private void orderDatabase(int price, int quantity, int delay, int id_customer, int id_agent)
        {   
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Test(Price,Quantity,Delay,AgentID,CustomerID) VALUES (@total_price,@quantity,@delay,@id_agent,@id_customer)", cn);
            cmd.Parameters.AddWithValue("@total_price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@delay", delay);
            cmd.Parameters.AddWithValue("@id_customer", id_customer);
            cmd.Parameters.AddWithValue("@id_agent", id_agent);
            cmd.ExecuteNonQuery();
        }

        // les 3 fonctions qui suivent servent juste a determiner la page active
        private void recapBtn_Click(object sender, EventArgs e)
        {
            panelRecap.Visible = true;
            panelOrder.Visible = false;
            panelCatalog.Visible = false;
            panel1.Visible = false;
            messagefinal.Text = "";
        }
        private void orderPageBtn_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;
            panelRecap.Visible = false;
            panelCatalog.Visible = false;
            panel1.Visible = false;
            messagefinal.Text = "";
        }

        private void delayBtn_Click(object sender, EventArgs e)
        {
            messagefinal.Text = "";
            panel1.Visible = true;
            panelRecap.Visible = true;
            panelOrder.Visible = false;
            panelCatalog.Visible = false;
            messagefinal.Text = "";

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

            // on parcourir le dictionnaire trier pour afficher le recap
            foreach (KeyValuePair<string, int> bike in order.RegroupedBikesDict)
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

        private void resetAllTables()
        {
            stockTable.Reset();
            partsToOrderTable.Reset();
            cityTable.Reset();
            explorerTable.Reset();
            adventureTable.Reset();
        }

        private int bikesAvailable()
        {
            stockTable.Reset();
            partsToOrderTable.Reset();
            //We first check how many bike we can make using the general stock

            if (cn.State == ConnectionState.Closed) { cn.Open(); };
            
            MySqlCommand commandStock= new MySqlCommand("SELECT * FROM Stock ", cn);
            MySqlDataReader myReaderStock;
            myReaderStock = commandStock.ExecuteReader();
            DataTable dataTableStock = new DataTable();
            dataTableStock.Load(myReaderStock);
            stockTable = dataTableStock.Copy();

            MySqlCommand commandParts = new MySqlCommand("SELECT * FROM PartsToOrderStock ", cn);
            MySqlDataReader myReaderParts;
            myReaderParts = commandParts.ExecuteReader();
            DataTable dataTableParts = new DataTable();
            dataTableParts.Load(myReaderParts);
            partsToOrderTable = dataTableParts.Copy();

            int min = int.MaxValue;
            int quantity;
            foreach (int value in Enumerable.Range(1, order.Bikes_list.Count))
            {
                foreach (DataRow row in stockTable.Rows)
                {
                    DataRow new_row;
                    quantity = row.Field<int>("quantity") / row.Field<int>("min");

                    if (quantity < min)
                    {
                        min = quantity;
                    }
                    if (row.Field<int>("quantity") > row.Field<int>("min"))
                    {
                    
                        row["quantity"] = row.Field<int>("quantity") - 1;

                    }
                    else
                    {
                        new_row = partsToOrderTable.NewRow();

                        new_row["name"] = row["name"];
                        new_row["quantity"] = row["quantity"];
                        new_row["Color"] = "General";
                        new_row["Size"] = "General";
                        new_row["min"] = row["min"];
                        new_row["Type"] = "General";

                        partsToOrderTable.Rows.Add(new_row);
                    }

                }
            }

            //We return the max number of bikes that we can make
            return min;

        }

        private int tables(DataTable dataTable, string[] subs)
        {
            int missingBikes = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                string color = row.Field<String>("Color");
                string size = row.Field<String>("Size");
                int quantity = row.Field<int>("quantity");
                int min = row.Field<int>("min");
                DataRow new_row;

                if (quantity > min)
                {
                    if ((color == subs[2] && size == subs[1]) || (size is null) || (color is null && size == subs[1]) || (color == "Black" && size == subs[1]))
                    {
                        row["quantity"] = quantity - 1;

                    }
                }
                else
                {
                    new_row = partsToOrderTable.NewRow(); 

                    new_row["name"] = row["name"];
                    new_row["quantity"] = row["quantity"];
                    new_row["Color"] = row["Color"];
                    new_row["Size"] = row["Size"];
                    new_row["min"] = row["min"];
                    new_row["Type"] = subs[0];

                    partsToOrderTable.Rows.Add(new_row);
                    missingBikes = 1;
                }

            }
            return missingBikes;
        }
        private int customBikes()
        {
            int bikesMissing = 0;
            //Check how many of the ordered bikes we can make with our current specific parts

            cityTable.Reset();
            explorerTable.Reset();
            adventureTable.Reset();

            foreach (KeyValuePair<String, int> kvp in order.RegroupedBikesDict)
            {
                string s = kvp.Key;
                string[] subs = s.Split(',');

                if (cn.State == ConnectionState.Closed) { cn.Open(); };

                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM {0}Stock", subs[0]), cn);
                MySqlDataReader myReader;
                myReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(myReader);

                //Make it more generic later
                foreach (int value in Enumerable.Range(1, kvp.Value))
                {
                    if (subs[0] == "City")
                    {
                        if (cityTable.Rows.Count == 0)
                        {
                            cityTable = dataTable.Copy();
                            bikesMissing = tables(cityTable, subs);
                        }
                        else
                        {
                            bikesMissing += tables(cityTable, subs);
                        }
                    }
                    else if (subs[0] == "Explorer")
                    {
                        if (explorerTable.Rows.Count == 0)
                        {
                            explorerTable = dataTable.Copy();
                            bikesMissing = tables(explorerTable, subs);
                        }
                        else
                        {
                            bikesMissing += tables(explorerTable, subs);
                        }
                        
                    }
                    else if (subs[0] == "Adventure")
                    {
                        if (adventureTable.Rows.Count == 0)
                        {
                            adventureTable = dataTable.Copy();
                            bikesMissing = tables(adventureTable, subs);
                        }
                        else
                        {
                            bikesMissing += tables(adventureTable, subs);
                        }

                    }
                }
            }
            return bikesMissing;
        }

        private void updateDatabaseTables()
        {
            if (cn.State == ConnectionState.Closed) { cn.Open(); };

            string eQuery = "Select * from ExplorerStock";
            MySqlDataAdapter explorer = new MySqlDataAdapter(eQuery, cn);
            MySqlCommandBuilder ecmb = new MySqlCommandBuilder(explorer);
            explorer.Update(explorerTable);

            string aQuery = "Select * from AdventureStock";
            MySqlDataAdapter adventure = new MySqlDataAdapter(aQuery, cn);
            MySqlCommandBuilder acmb = new MySqlCommandBuilder(adventure);
            adventure.Update(adventureTable);

            string cQuery = "Select * from CityStock";
            MySqlDataAdapter city = new MySqlDataAdapter(cQuery, cn);
            MySqlCommandBuilder ccmb = new MySqlCommandBuilder(city);
            city.Update(cityTable);

            string sQuery = "Select * from Stock";
            MySqlDataAdapter stock = new MySqlDataAdapter(sQuery, cn);
            MySqlCommandBuilder scmb = new MySqlCommandBuilder(stock);
            stock.Update(stockTable);

            string pQuery = "Select * from PartsToOrderStock";
            MySqlDataAdapter parts = new MySqlDataAdapter(pQuery, cn);
            MySqlCommandBuilder pcmb = new MySqlCommandBuilder(parts);
            parts.Update(partsToOrderTable);

        }
        private int delayOrder(Order order)
        {
            int maxGeneralBikes = bikesAvailable();
            int missingCustomBikes = customBikes();

            int delay = 3; //3 days minimum

            // Return more days if the not enough stock

            // Verify if enough general stock
            if (order.Bikes_list.Count <= maxGeneralBikes)
            {
                if(missingCustomBikes == 0)
                {
                    Console.WriteLine("All parts available");
                }
                else
                {
                    // Buy custom stock
                    delay += missingCustomBikes;
                    Console.WriteLine("Custom parts low");
                }
                
                
            }
            else
            {
                Console.WriteLine("Low general stock");
                // Buy general stock
                delay += order.Bikes_list.Count - maxGeneralBikes;
                
                if (missingCustomBikes == 0)
                {
                    Console.WriteLine("Custom parts available only");
                }
                else
                {
                    // Buy custom stock
                    delay += missingCustomBikes;
                    Console.WriteLine("All parts low");
                }
                
            }
            return delay;
        }

        // pour vider le panier et recommencer une commande 
        private void resetBtn_Click(object sender, EventArgs e)
        {
            order.reset();
            totalPriceTxt.Text = "";
            recapTxt.Text = "";
        }

        // pour confirmer une commande 
        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
            
            if (cn.State == ConnectionState.Closed) { cn.Open(); };
            if (order.Bikes.Count != 0 && nameBox.Text.Length != 0 && phoneBox.Text.Length != 0 && adressBox.Text.Length != 0)
            {
                messagefinal.Text = "Sending order ...";
                customerTable();
                //We associate a customer for our order.
                order.SetCustomer(customer);
                //We associate an agent for our order.
                order.Add_Agent(agent);                        
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

                // Update the tables
                updateDatabaseTables();
                //Send order to database
                orderDatabase(Int32.Parse(totalPriceTxt.Text), order.Bikes_list.Count, delay, customer.Id, agent.Id);
                // Update agent table
                MySqlCommand cmdAgent = new MySqlCommand(String.Format("UPDATE Agent SET OrdersDone = OrdersDone+1 WHERE idAgent = {0}", agent.Id), cn);
                cmdAgent.ExecuteReader();
                cn.Close();
                order.reset();
                totalPriceTxt.Text = "";
                recapTxt.Text = "";
                messagefinal.Text = "Thank you for your order :)";
                delaytxt.Text = "";
            }
            else if (order.Bikes.Count == 0)
            {
                messagefinal.Text = "Please choose articles first :)";
            }
            else
            {
                messagefinal.Text = "Complete the cases";
            }
        }

        private void customerTable()
        {
            string cust_id = "0";
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Customer WHERE Phone = {0}", phoneBox.Text), cn);
            DataTable data = new DataTable();
            data.Load(command.ExecuteReader());
            if (data.Rows.Count != 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name = row.Field<String>("Name");
                    string phone = row.Field<String>("Phone");
                    string adress = row.Field<String>("Adress");

                    cust_id = (row["idCustomer"]).ToString();
                    Customer tempCustomer = new Customer(name, phone, adress);
                    customer = tempCustomer;
                }

            }
            else
            {
                Customer tempCustomer = new Customer(nameBox.Text, phoneBox.Text, adressBox.Text);
                customer = tempCustomer;
                MySqlCommand cmd0 = new MySqlCommand("INSERT INTO Customer(Name,Phone,Adress) VALUES (@name,@phone,@adress)", cn);
                cmd0.Parameters.AddWithValue("@name", customer.Name);
                cmd0.Parameters.AddWithValue("@phone", customer.Phone);
                cmd0.Parameters.AddWithValue("@adress", customer.Adress);
                cmd0.ExecuteNonQuery();
                cust_id = cmd0.LastInsertedId.ToString();
            }

        }
        private void catalogBtn_Click(object sender, EventArgs e)
        {
            panelCatalog.Visible = true;
            panelOrder.Visible = false;
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
            if(order.Bikes_list.Count != 0)
            {
                DateTime dt = DateTime.Now;
                //We estimate the time
                delay = delayOrder(order);
                string s = dt.AddDays(delay).ToString();
                string[] subs = s.Split(' ');
                delaytxt.Text = String.Format("Delivery on {0}", subs[0]);
                panel1.Visible = true;
            }
            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (user.Text.Length != 0 && password.Text.Length != 0)
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); };
                MySqlCommand command = new MySqlCommand("SELECT * FROM Agent", cn);
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                if (data.Rows.Count != 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        string userDB = row.Field<string>("user");
                        string passwordDB = row.Field<string>("password");
                        string nameDB = row.Field<string>("Name");
                        string phoneDB = row.Field<string>("Phone");
                        int idDB = row.Field<int>("idAgent");

                        if (userDB == user.Text && passwordDB == password.Text) 
                        {
                            Agent tempAgent = new Agent(nameDB, idDB, phoneDB, "idk");
                            agent = tempAgent;
                            Console.WriteLine("Connected");
                            panel2.Visible = false;
                        }
                        else if (userDB == user.Text && passwordDB != password.Text)
                        {
                            connectTxt.Text = "Wrong password";
                        }
                        else
                        {
                            connectTxt.Text = "Wrong user";
                        }
                    }
                }
                else
                {
                    connectTxt.Text = "No agent in the database";
                }
            }
            else
            {
                connectTxt.Text = "Complete all the cases";
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emptyCheckout_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            phoneBox.Text = "";
            adressBox.Text = "";
            messagefinal.Text = "";
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled =!char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(errorPhone, "Numeric Valuer Only");
                errorPhone.Text = "Numeric Valuer Only";
            }
            else
            {
                errorProvider1.SetError(errorPhone, "");
                errorPhone.Text = "";
            }
        }
    }
}
