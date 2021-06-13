using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOVELO_PlanningList
{
    public partial class Connexion : Form
    {
        //This partial class returns my identification parameters from the Windows Form

        public Connexion()            
        {
            InitializeComponent();
        }

        public string identifiant { get { return textBox1.Text; } set { textBox1.Text = value; } } 
        public string password { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public string role { get { return textBox3.Text; } set { textBox3.Text = value; } }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;  //To confirm modification
        }
    }
}
