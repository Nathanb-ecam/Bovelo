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
        bool test;

        Schedule GT;
        Assembler a;
        Planning_Master b;

        ListViewItem element;

        private int OrderDuration;

        private void button1_Click(object sender, EventArgs e) // connexion bdd
        {
            if (button1.Text == "Se connecter")
            {               
                string identifiant;
                string password;

                using (Connexion m = new Connexion())
                {
                    if (m.ShowDialog() == DialogResult.Yes)
                    {
                        identifiant = m.identifiant;
                        password = m.password;

                        a = new Assembler(identifiant, password);
                        b = new Planning_Master(identifiant, password);

                        using (cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=DataBase;port=63307;password=1234"))
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

                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users", cn);
                            using (MySqlDataReader Lire = cmd.ExecuteReader())
                            {
                                if(Lire.Read())
                                {
                                    string identDB = Lire["userName"].ToString();
                                    string pwDB = Lire["Password"].ToString();

                                    if (identifiant == identDB && password == pwDB)
                                    {
                                        MessageBox.Show("Bienvenue " + identifiant + " !");
                                        keepOpen();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mauvaise identification, try again");
                                        rentrePas();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else //pour la deco
            {
                rentrePas();
            }
        }    

        public void keepOpen()
        {          
            cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=DataBase;port=63307;password=1234");
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

        private void button2_Click(object sender, EventArgs e) //pour chercher nos lignes de commandes ds la bdd. Deux options s'offre a nous, où on change encore la bdd où alors je fais des SELECT de plusieurs tables. J'ai choissi l'option 1 mais on peut modifier par après.      
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

        private void jaiFinisMaTacheToolStripMenuItem_Click(object sender, EventArgs e) //j'ai finis ma tache donc je la supprime de la bdd
        {
            List<string> info = new List<string>();
            if (Connecter)
            {
                if(listView1.SelectedItems.Count > 0) //je peux pas selectioner du vide
                {
                    ListViewItem element = listView1.SelectedItems[0]; //mon premier element ici est l'id ou peux rajouter les autres par apres #flemme

                    string idBike = element.SubItems[0].Text;

                    var command = new MySqlCommand("SELECT Type, Color, Size From Bike WHERE idBike = @idBike", cn);
                    command.Parameters.AddWithValue("@idBike", idBike);
                    //var reader = command.ExecuteReader();
                    using (MySqlDataReader Lire = command.ExecuteReader())
                    {
                        while (Lire.Read())
                        {
                            string Type = Lire["Type"].ToString();
                            string Color = Lire["Color"].ToString();
                            string Size = Lire["Size"].ToString();
                            //MessageBox.Show(Type + " " + Color + " " + Size);    
                            info.Add(Type);
                            info.Add(Color);
                            info.Add(Size);
                        }
                    }

                    command.CommandText = "DELETE FROM Bike WHERE idBike = @idBike";                    
                    command.ExecuteNonQuery();
                    element.Remove();
                    MessageBox.Show("Supprimé");

                    //Supprimer mon stock  
                    Stock(info[0], info[1], info[2]);

                    
                }
            }
        }       

        public void Stock(string Type, string Color, string Size)
        {
            //C'est immonde mais je sais pas comment faire plus proprement

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
                MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE Name = @Name", cn);                
                command.Parameters.AddWithValue("@Name", i);                
                command.ExecuteNonQuery();                
            }

            foreach (string i in composant2)
            {
                MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 2 WHERE Name = @Name", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.ExecuteNonQuery();
            }

            foreach (string i in composant4)
            {
                MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 4 WHERE Name = @Name", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.ExecuteNonQuery();
            }

            //City Parts
            if ("city" == Type.ToLower())
            {
                foreach(string i in composantCity1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantCity2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);                    
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantCity1_SSCT)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE Name=@Name", cn);
                    command.Parameters.AddWithValue("@Name", i);                    
                    command.ExecuteNonQuery();
                }
            }

            //Explorer Parts
            if ("explorer" == Type.ToLower())
            {
                foreach (string i in composantExplo1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantExplo2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantExplo1_SSCT)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE Name=@Name", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.ExecuteNonQuery();
                }
            }

            //Adventure Parts
            if ("adventure" == Type.ToLower())
            {
                foreach (string i in composantAdventure1)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size AND Color=@Color)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.ExecuteNonQuery();
                }
                foreach (string i in composantAdventure2)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                    command.Parameters.AddWithValue("@Name", i);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.ExecuteNonQuery();
                }                
            }

            //Size Different common Parts
            foreach (string i in composantSize1)
            {
                MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 1 WHERE (Name=@Name AND Size=@Size)", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.Parameters.AddWithValue("@Size", Size);
                command.ExecuteNonQuery();
            }

            foreach (string i in composantSize2)
            {
                MySqlCommand command = new MySqlCommand("UPDATE Stock SET Quantity = Quantity - 2 WHERE (Name=@Name AND Size=@Size)", cn);
                command.Parameters.AddWithValue("@Name", i);
                command.Parameters.AddWithValue("@Size", Size);
                command.ExecuteNonQuery();
            }           

        }
        
        private void myBananasAreRipeToolStripMenuItem_Click(object sender, EventArgs e) //modification de ma commande
        {
            if (listView1.SelectedItems.Count > 0) //je peux pas selectioner du vide
            {
                ListViewItem element = listView1.SelectedItems[0]; //je rerentre mes données ds cette boucle, pour un code plus soignée on peut les sortir mais flemme
                string idBike = element.SubItems[0].Text;
                string Type = element.SubItems[1].Text;               
                string Monteur = element.SubItems[4].Text;
                string Horaire = element.SubItems[5].Text;
                string DureeTache = element.SubItems[6].Text;

                using(Détail_et_modification m = new Détail_et_modification()) //On crée notre nouvelle instante modification et detail
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
                        cmd.Parameters.AddWithValue("@idBike", idBike);  //comme readonly pas de m.ID car je ne fais que afficher
                        cmd.ExecuteNonQuery();

                        //je le met directement à jour sans le bouton "actualiser"
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
        {
            using(AddCommand m2 = new AddCommand())
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
        {
            this.element = listView1.SelectedItems[0]; //Je selectionne mes variables avec lequels je veux travailler

            string DureeTache = element.SubItems[6].Text;
            this.OrderDuration = Int32.Parse(DureeTache);

            this.timer1.Enabled = true;
                      

            //    //MySqlCommand cmd = new MySqlCommand("UPDATE Bike SET DureeTache=@DureeTache WHERE idBike=@idBike", cn); //MiseAJourBDD
            //    //cmd.Parameters.AddWithValue("@DureeTache", DRTache.ToString());
            //    //cmd.Parameters.AddWithValue("@idBike", idBike);
        }

        private void TimeIsOn(object sender, EventArgs e)
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

