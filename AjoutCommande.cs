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
    public partial class AjoutCommande : Form
    {
        public AjoutCommande()
        {
            InitializeComponent();
        }

        public string Type { get { return textBox1.Text; } }
        public string Size2 { get { return textBox2.Text; } }
        public string Color { get { return textBox3.Text; } }
        public string Monteur{ get { return textBox4.Text; } }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
