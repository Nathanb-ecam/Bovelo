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

        Horaire GT;

        private void button1_Click(object sender, EventArgs e) // connexion bdd
        {
            if(button1.Text == "Se connecter")
            {
                cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=DataBase;port=63307;password=1234");
                try
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    button1.Text = "Se déconnecter";
                    Connecter = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
                
            }else //pour la deco
            {
                cn.Close();
                button1.Text = "Se connecter";
                Connecter = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //pour chercher nos lignes de commandes ds la bdd. Deux options s'offre a nous, où on change encore la bdd où alors je fais des SELECT de plusieurs tables. J'ai choissi l'option 1 mais on peut modifier par après.      
        {
            if (Connecter)
            {
                listView1.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Bike ", cn);
                using(MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read()) 
                    {
                        string ID = Lire["idBike"].ToString();
                        string Type  = Lire["Type"].ToString();
                        string Color = Lire["Color"].ToString();
                        string Size  = Lire["Size"].ToString();
                        string Monteur = Lire["Monteur"].ToString();
                        string Horaire = Lire["HoraireTache"].ToString() + " durée:" + Lire["DureeTache"].ToString() + " minutes";

                        listView1.Items.Add(new ListViewItem(new[] { ID, Type, Color, Size, Monteur, Horaire }));

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

                using(Détail_et_modification m = new Détail_et_modification()) //On crée notre nouvelle instante modification et detail
                {

                    GT = new Horaire();
                    Monteur a = new Monteur(m.Monteur);
                    
                    m.idBike = idBike;
                    m.Monteur = Monteur;
                    GT.Horaire1 = Horaire;
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

                        a.addMonteur(m.Monteur);

                        //je le met directement à jour sans le bouton "actualiser"
                        element.SubItems[1].Text = m.Type;
                        element.SubItems[4].Text = m.Monteur;
                        element.SubItems[5].Text = GT.Horaire1;
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
            //ListViewItem element = listView1.SelectedItems[0]; 
            //string Horaire = element.SubItems[5].Text;
        
            //int DRTache = Int32.Parse(Horaire.Substring(25, 2));

            //bool res = true;
            //while (res)
            //{
    
            //    System.Timers.Timer montimer = new System.Timers.Timer(); // Initialise mon compteur
            //    montimer.Interval = 6000; // Interval en milliseconde 60000 = 1 minutes
            //    montimer.Start(); // Lance Mon compteur
            //    montimer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed); // Chaque 10 minutes mon évènement se déclenche.

            //    if (DRTache < 1)
            //    {
            //        MessageBox.Show("Tache terminée");
            //        res = false;
            //    }
            //}
        }
    }
}
