using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BOVELO_PlanningList
{
    public partial class Détail_et_modification : Form
    {
        string changement1;
        
        //Nos get/setter pour nos modif
        public string idBike { get { return textBox4.Text; } set { textBox4.Text = value; } } //j'ai mis en readonly, on modifie pas l'id d'une commande
        public string Monteur { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string HoraireTache { get { return dateTimePicker1.Value.ToString(); } set { changement1 = value; } }
        public string DureeTache { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public string Type { get { return textBox3.Text; } set { textBox3.Text = value; } }


        public Détail_et_modification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;  //Pour la modification du forme enfant soit pris en compte dans la forme mère

        }


        //je fais une connexion bdd degeux car on rajouterai peut etre des mots de passe,...

        MySqlConnection cn;

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("SERVER=193.191.240.67;user=nick;database=DataBase;port=63307;password=1234");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            listView5.Items.Clear();

            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM CommandedParts WHERE idBike=@idBike)", cn);
            cmd2.Parameters.AddWithValue("@idBike", idBike);



            //switch (Type.ToLower())
            //{
            //    case "city":

            //        Part VeloCity = new Part(1, 1, 2, 2, 5, 2, 5, 2);

            //        cmd2.Parameters.AddWithValue("@NumberGuidon", VeloCity.getNombreChassis());
            //        cmd2.Parameters.AddWithValue("@NumberChassis", VeloCity.getnombreGuidon());
            //        cmd2.Parameters.AddWithValue("@NumberRoue", VeloCity.getnombreRoue());
            //        cmd2.Parameters.AddWithValue("@Location", VeloCity.getLocation());
            //        cmd2.ExecuteNonQuery();
            //        cmd2.Parameters.Clear();

            //        listView5.Items.Add(new ListViewItem(new[] { String.Format("Il faut {0} guidons,/n {1} chassis, /n {2} roue", VeloCity.getNombreChassis(), VeloCity.getnombreGuidon(), VeloCity.getnombreRoue()) }));
            //        break;

            //    case "adventure":

            //        Part VeloAdventure = new Part(1, 2, 2, 5, 1, 5, 1, 5);

            //        cmd2.Parameters.AddWithValue("@NumberGuidon", VeloAdventure.getNombreChassis());
            //        cmd2.Parameters.AddWithValue("@NumberChassis", VeloAdventure.getnombreGuidon());
            //        cmd2.Parameters.AddWithValue("@NumberRoue", VeloAdventure.getnombreRoue());
            //        cmd2.Parameters.AddWithValue("@Location", VeloAdventure.getLocation());
            //        cmd2.ExecuteNonQuery();
            //        cmd2.Parameters.Clear();

            //        listView5.Items.Add(new ListViewItem(new[] { String.Format("Il faut {0} guidons, {1} chassis, {2} roue", VeloAdventure.getNombreChassis(), VeloAdventure.getnombreGuidon(), VeloAdventure.getnombreRoue()) }));
            //        break;

            //    case "explorer":

            //        Part VeloExplorer = new Part(1, 3, 2, 2, 2, 1, 8, 2);

            //        cmd2.Parameters.AddWithValue("@NumberGuidon", VeloExplorer.getNombreChassis());
            //        cmd2.Parameters.AddWithValue("@NumberChassis", VeloExplorer.getnombreGuidon());
            //        cmd2.Parameters.AddWithValue("@NumberRoue", VeloExplorer.getnombreRoue());
            //        cmd2.Parameters.AddWithValue("@Location", VeloExplorer.getLocation());
            //        cmd2.ExecuteNonQuery();
            //        cmd2.Parameters.Clear();

            //        listView5.Items.Add(new ListViewItem(new[] { String.Format("Il faut {0} guidons, {1} chassis, {2} roue", VeloExplorer.getNombreChassis(), VeloExplorer.getnombreGuidon(), VeloExplorer.getnombreRoue()) }));
            //        break;

            //    default:
            //        MessageBox.Show("hhuhuhuh");
            //        break;
            //}
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count > 0) //pas selectioner le vide
                                                   //pour afficher la localité des pieces selectioner
            {
                ListViewItem element = listView5.SelectedItems[0];

                MySqlCommand cmd3 = new MySqlCommand("SELECT Location FROM Parts WHERE idBike=@idBike", cn); //à modif pour une recherche plus précise, même chose qu'avant quoi
                cmd3.Parameters.AddWithValue("@idBike", idBike);

                using (MySqlDataReader Lire3 = cmd3.ExecuteReader())
                {
                    while (Lire3.Read())
                    {
                        string Location = Lire3["Location"].ToString();

                        textBox5.Text = Location; //j'affiche la location de ma piece selectioner ds le textbox
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            this.changement1 = result.ToString();
        }
    }
}

