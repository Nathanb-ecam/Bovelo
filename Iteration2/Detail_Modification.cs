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

        //This partial class will help the manager change an order and the assembler know the commond more in details
    
    {
        string changement1;
        bool Connecter;
        MySqlConnection cn;
        LocationParts parts;
        
        public string idBike { get { return textBox4.Text; } set { textBox4.Text = value; } } //readonly, we do not modify the id of an order
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
            DialogResult = DialogResult.Yes;  //To confirm changes in the form application
        }                 

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            this.changement1 = result.ToString();     
        }     

        private void button2_Click(object sender, EventArgs e)
            //this button shows the different pieces and their location
        {
            parts = new LocationParts();

            List<string> commonParts = parts.getCommonParts();
            string commonLocation = parts.getCommonLocation();
           
            foreach(string i in commonParts)
            {
                listView1.Items.Add(i);
            }            
            textBox5.Text = commonLocation;
            
            if ("city" == Type.ToLower())
            {
                List<string> cityParts = parts.getCityParts();
                string cityLocation = parts.getCityLocation();
                foreach (string i in cityParts)
                {
                    listView2.Items.Add(i);
                }
                textBox6.Text = cityLocation;
            }

            if ("adventure" == Type.ToLower())
            {
                List<string> adventureParts = parts.getAdventureParts();
                string adventureLocation = parts.getAdventureLocation();
                foreach (string i in adventureParts)
                {
                    listView2.Items.Add(i);
                }
                textBox6.Text = adventureLocation;
            }

            if ("explorer" == Type.ToLower())
            {
                List<string> explorerParts = parts.getExplorerParts();
                string explorerLocation = parts.getExplorerLocation();
                foreach (string i in explorerParts)
                {
                    listView2.Items.Add(i);
                }
                textBox6.Text = explorerLocation;
            }
        }
    }
}

