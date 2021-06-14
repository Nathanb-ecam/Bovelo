using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BOVELO_PlanningList
{
    public partial class PlanningList : Form
    {
        public PlanningList()
        {
            InitializeComponent();
        }
    
        MySqlConnection cn;      

        bool Connecter = false;        

        Schedule GT;
        Assembler a;
        Planning_Master b;

        ListViewItem element;

        private int OrderDuration;

        private void button1_Click(object sender, EventArgs e) 
            
            //This button makes connection with my database
        
        {
            if (button1.Text == "Se connecter")
            {
                string identifiant;
                string password;
                string role;

                using (Connexion m = new Connexion())

                //Here i'm calling my partial class Connection to retreive its information passed thru

                {
                    if (m.ShowDialog() == DialogResult.Yes)
                    {
                        identifiant = m.identifiant;
                        password = m.password;
                        role = m.role;
                        
                        using (cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=mydb ;port=63307;password=1234"))
                        {
                            try
                            {
                                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                                button1.Text = "Se déconnecter";
                                Connecter = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            if ("agent" == role.ToLower())
                            {
                                MySqlCommand command = new MySqlCommand("SELECT * FROM Agent", cn);
                                DataTable data = new DataTable();
                                data.Load(command.ExecuteReader());
                                if (data.Rows.Count != 0)
                                {
                                    foreach (DataRow row in data.Rows)
                                    {
                                        string userAgent = row.Field<string>("user");
                                        string passwordAgent = row.Field<string>("password");
                                        string nameAgent = row.Field<string>("Name");
                                        string phoneAgent = row.Field<string>("Phone");
                                        int idAgent = row.Field<int>("idAgent");

                                        if (userAgent == identifiant && passwordAgent == password)
                                        {
                                            MessageBox.Show("Connected");
                                            Connecter = true;
                                            keepOpen();
                                            b = new Planning_Master(identifiant, password);
                                        }
                                        else if (userAgent == identifiant && passwordAgent != password)
                                        {
                                            MessageBox.Show("Wrong password");
                                            rentrePas();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Wrong user");
                                            rentrePas();
                                        }
                                    }
                                }
                            }

                            if("assembler" == role.ToLower())
                            {
                                MySqlCommand command = new MySqlCommand("SELECT * FROM Assembler", cn);
                                DataTable data = new DataTable();
                                data.Load(command.ExecuteReader());
                                if (data.Rows.Count != 0)
                                {
                                    foreach (DataRow row in data.Rows)
                                    {
                                        string userAssembler = row.Field<string>("User");
                                        string passwordAssembler = row.Field<string>("Password");
                                        string nameAssembler = row.Field<string>("Name");
                                        string phoneAssembler = row.Field<string>("Phone");
                                        int idAssembler = row.Field<int>("idAssembler");

                                        if (userAssembler == identifiant && passwordAssembler == password)
                                        {
                                            MessageBox.Show("Connected");
                                            Connecter = true;
                                            keepOpen();
                                            a = new Assembler(identifiant, password);
                                        }
                                        else if (userAssembler == identifiant && passwordAssembler != password)
                                        {
                                            MessageBox.Show("Wrong password");
                                            rentrePas();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Wrong user");
                                            rentrePas();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                rentrePas();
                            }
                        }
                    }                   
                    else
                    {
                        rentrePas();
                    }
                }
            }
        }    

        public void keepOpen()
        {          
            cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=mydb ;port=63307;password=1234");
            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                button1.Text = "Se déconnecter";
                Connecter = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }

        public void rentrePas()
        {
            cn.Close();
            button1.Text = "Se connecter";
            Connecter = false;
        }

        private void button2_Click(object sender, EventArgs e) 
            
            //This method displays our orders in the listview

        {
            if(Connecter)
            {
                listView1.Items.Clear();                
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Bike ", cn);
                using (MySqlDataReader Lire = cmd2.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["idBike"].ToString();
                        string Type = Lire["Type"].ToString();
                        string Color = Lire["Color"].ToString();
                        string Size = Lire["Size"].ToString();
                        string Monteur = Lire["Monteur"].ToString();
                        string Horaire = Lire["HoraireTache"].ToString();
                        string DureeTache = Lire["DureeTache"].ToString();

                        listView1.Items.Add(new ListViewItem(new[] { ID, Type, Color, Size, Monteur, Horaire, DureeTache }));

                    }
                }                            
            }
            else { MessageBox.Show("Vous n'etes pas connecter"); }
        }

        private void jaiFinisMaTacheToolStripMenuItem_Click(object sender, EventArgs e) 
        {

            //This method will delete my order and change the stock according to the bike produced

            List<string> info = new List<string>();
            if (Connecter)
            {
                if(listView1.SelectedItems.Count > 0) //cannot select nothing
                {
                    ListViewItem element = listView1.SelectedItems[0]; 
                    string idBike = element.SubItems[0].Text;

                    var command = new MySqlCommand("SELECT Type, Color, Size From Bike WHERE idBike = @idBike", cn);
                    command.Parameters.AddWithValue("@idBike", idBike);                    
                    using (MySqlDataReader Lire = command.ExecuteReader())
                    {
                        while (Lire.Read())
                        {
                            string Type = Lire["Type"].ToString();
                            string Color = Lire["Color"].ToString();
                            string Size = Lire["Size"].ToString();                            
                            info.Add(Type);
                            info.Add(Color);
                            info.Add(Size);
                        }
                    }
                    command.CommandText = "DELETE FROM Bike WHERE idBike = @idBike";                    
                    command.ExecuteNonQuery();
                    element.Remove();
                    MessageBox.Show("Supprimé");

                    //update stock 
                    Stock(info[0], info[1], info[2]);                    
                }
            }
        }       

        public void Stock(string Type, string Color, string Size)
        {
            //this method updates the stock specifically to the order finished

            CommonParts a = new CommonParts();
            List<string> composant1 = a.getList_Nbr1();
            List<string> composant2 = a.getList_Nbr2();
            List<string> composant4 = a.getList_Nbr4();

            CityParts b = new CityParts();
            List<string> composantCity1 = b.getList_Nbr1();
            List<string> composantCity2 = b.getList_Nbr2();
            List<string> composantCity1_SSCT = b.getList_Nbr1_SSCT();

            ExplorerParts c = new ExplorerParts();
            List<string> composantExplo1 = c.getList_Nbr1();
            List<string> composantExplo2 = c.getList_Nbr2();
            List<string> composantExplo1_SSCT = c.getList_Nbr1_SSCT();

            AdventureParts d = new AdventureParts();
            List<string> composantAdventure1 = d.getList_Nbr1();
            List<string> composantAdventure2 = d.getList_Nbr2();

            SizeParts e = new SizeParts();
            List<string> composantSize1 = e.getList_Nbr1();
            List<string> composantSize2 = e.getList_Nbr2();


            //Common Parts
            foreach (string i in composant1)
            {
                MySqlCommand command = new MySqlCommand("UPDATE GeneralStock SET Quantity = Quantity - 1 WHERE Name = @Name", cn);                
                command.Parameters.AddWithValue("@Name", i);                
                command.ExecuteNonQuery();                
            }

            foreach (string i in composant2)
            {
                MySqlCommand command = new MySqlCommand("UPDATE GeneralStock SET Quantity = Quantity - 2 WHERE Name = @Name", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.ExecuteNonQuery();
            }

            foreach (string i in composant4)
            {
                MySqlCommand command = new MySqlCommand("UPDATE GeneralStock SET Quantity = Quantity - 4 WHERE Name = @Name", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.ExecuteNonQuery();
            }

            //City Parts
            if ("city" == Type.ToLower())
            {
                foreach(string i in composantCity1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE CityStock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantCity2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE CityStock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);                    
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantCity1_SSCT)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE CityStock SET Quantity = Quantity - 1 WHERE Name=@Name", cn);
                    command.Parameters.AddWithValue("@Name", i);                    
                    command.ExecuteNonQuery();
                }
            }

            //Explorer Parts
            if ("explorer" == Type.ToLower())
            {
                foreach (string i in composantExplo1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE ExplorerStock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantExplo2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE ExplorerStock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantExplo1_SSCT)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE ExplorerStock SET Quantity = Quantity - 1 WHERE Name=@Name", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.ExecuteNonQuery();
                }
            }

            //Adventure Parts
            if ("adventure" == Type.ToLower())
            {
                foreach (string i in composantAdventure1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE AdventureStock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantAdventure2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE AdventureStock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.ExecuteNonQuery();
                }                
            }

            //Size Different common Parts
            foreach (string i in composantSize1)
            {
                MySqlCommand command = new MySqlCommand("UPDATE GeneralStock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size)", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.Parameters.AddWithValue("@Size", Size);
                command.ExecuteNonQuery();
            }

            foreach (string i in composantSize2)
            {
                MySqlCommand command = new MySqlCommand("UPDATE GeneralStock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.Parameters.AddWithValue("@Size", Size);
                command.ExecuteNonQuery();
            }

        }
        
        private void myBananasAreRipeToolStripMenuItem_Click(object sender, EventArgs e) 

            //This method will change my order, usefull for the manager

        {
            if (listView1.SelectedItems.Count > 0) 
            {
                ListViewItem element = listView1.SelectedItems[0]; 
                string idBike = element.SubItems[0].Text;
                string Type = element.SubItems[1].Text;               
                string Monteur = element.SubItems[4].Text;
                string Horaire = element.SubItems[5].Text;
                string DureeTache = element.SubItems[6].Text;

                using(Détail_et_modification m = new Détail_et_modification()) //Here we call on the partial class Detail_Modification that will send us the modified data
                {
                    GT = new Schedule(m.HoraireTache, m.DureeTache);
                    a = new Assembler(m.Monteur);                    
                    m.idBike = idBike;
                    a.getMonteur = Monteur;
                    GT.HoraireTache = Horaire;
                    GT.DureeTache = DureeTache;
                    m.Type = Type;

                    if(m.ShowDialog() == DialogResult.Yes) 
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE Bike SET Monteur=@monteur, HoraireTache=@HoraireTache, Type=@Type, DureeTache=@DureeTache WHERE idBike=@idBike", cn);
                        cmd.Parameters.AddWithValue("@monteur", m.Monteur);
                        cmd.Parameters.AddWithValue("@HoraireTache", m.HoraireTache);
                        cmd.Parameters.AddWithValue("@DureeTache", m.DureeTache);
                        cmd.Parameters.AddWithValue("@Type", m.Type);
                        cmd.Parameters.AddWithValue("@idBike", idBike); 
                        cmd.ExecuteNonQuery();
                        
                        //change in the form
                        element.SubItems[1].Text = m.Type;
                        element.SubItems[4].Text = m.Monteur;
                        element.SubItems[5].Text = GT.HoraireTache;
                        element.SubItems[6].Text = GT.DureeTache;

                        MessageBox.Show("Modifier");
                    }
                }

            }
        }

        private void ajoutCommandeToolStripMenuItem_Click(object sender, EventArgs e)

            //This method helps to add a new order to our planning list

        {
            using(AddCommand m2 = new AddCommand()) //use of the partial class AddCommand
            {
                if(m2.ShowDialog() == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Bike(Type,Size,Color,Monteur) VALUES(@Type,@Size,@Color,@Monteur)", cn);
                    cmd.Parameters.AddWithValue("@Type", m2.Type);
                    cmd.Parameters.AddWithValue("@Size", m2.Size2);
                    cmd.Parameters.AddWithValue("@Color", m2.Color);
                    cmd.Parameters.AddWithValue("@Monteur", m2.Monteur);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Added");
                }
            }
        }

        private void jeCommenceToolStripMenuItem_Click(object sender, EventArgs e)

            //This method start the counter when an assembler starts an order

        {
            this.element = listView1.SelectedItems[0]; 

            string DureeTache = element.SubItems[6].Text;
            this.OrderDuration = Int32.Parse(DureeTache);

            this.timer1.Enabled = true;
        }

        private void TimeIsOn(object sender, EventArgs e)

            //counter very quick as an exemple that it works but can be slowed down to a minute

        {
            if (this.OrderDuration > 0)
            {
                this.OrderDuration--;
                this.element.SubItems[6].Text = OrderDuration.ToString();
            }

            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time is up, delete this task");
            }
        }
    }
}

