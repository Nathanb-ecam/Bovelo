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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection cn;      

        bool Connecter = false;
        bool test;

        Horaire GT;
        Monteur a;
        Planning_Master b;

        ListViewItem element;

        private int DRTache1;

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

                        a = new Monteur(identifiant, password);
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
                                if (Lire.Read())
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
                                        Console.WriteLine("Mauvaise identification, try again");
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
            if (Connecter)
            {
                if(listView1.SelectedItems.Count > 0) //je peux pas selectioner du vide
                {
                    ListViewItem element = listView1.SelectedItems[0]; //mon premier element ici est l'id ou peux rajouter les autres par apres #flemme

                    string idBike = element.SubItems[0].Text;

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Bike WHERE idBike = @idBike", cn);
                    cmd.Parameters.AddWithValue("@idBike", idBike);
                    cmd.ExecuteNonQuery();

                    element.Remove();
                    MessageBox.Show("Supprimé");
                }
            }
        }
        
        private void myBananasAreRipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //je peux pas selectioner du vide
            {
                ListViewItem element = listView1.SelectedItems[0]; //je rerentre mes données ds cette boucle, pour un code plus soignée on peut les sortir mais flemme
                string idBike = element.SubItems[0].Text;
                string Type = element.SubItems[1].Text;
                string Color = element.SubItems[2].Text;
                string Size = element.SubItems[3].Text;
                string Monteur = element.SubItems[4].Text;
                string Horaire = element.SubItems[5].Text;
                string DureeTache = element.SubItems[6].Text;

                using(Détail_et_modification m = new Détail_et_modification()) //On crée notre nouvelle instante modification et detail
                {

                    GT = new Horaire(m.HoraireTache, m.DureeTache);
                    a = new Monteur(m.Monteur);
                    
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
            using(AjoutCommande m2 = new AjoutCommande())
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
            this.DRTache1 = Int32.Parse(DureeTache);

            this.timer1.Enabled = true;
                      

            //    //MySqlCommand cmd = new MySqlCommand("UPDATE Bike SET DureeTache=@DureeTache WHERE idBike=@idBike", cn); //MiseAJourBDD
            //    //cmd.Parameters.AddWithValue("@DureeTache", DRTache.ToString());
            //    //cmd.Parameters.AddWithValue("@idBike", idBike);
        }

        private void TimeIsOn(object sender, EventArgs e)
        {
            if (this.DRTache1 > 0)
            {
                this.DRTache1--;
                this.element.SubItems[6].Text = DRTache1.ToString();
            }

            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time is up, delete this task");
            }
        }
    }
}

