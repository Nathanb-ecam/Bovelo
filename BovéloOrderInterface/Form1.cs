using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BovéloOrderInterface
{
    public partial class Form1 : Form
    {
        int totalPrice = 0;
        
        public Form1()
        {
            InitializeComponent();
            modelBox.SelectedIndex = 0;
            sizeBox.SelectedIndex = 0;
            colorBox.SelectedIndex = 0;
            quantityBox.SelectedText = "1";

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void recapBtn_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelRecap.Visible = true;
            panelDelay.Visible = false;
            
            
        }

        private void delayBtn_Click(object sender, EventArgs e)
        {
            panelDelay.Visible = true;
            panelMain.Visible = false;
            panelRecap.Visible = false;
            // chercher dans la bdd si vélo en stock puis estimer delay
            //delayEstimater();
            if (totalPrice != 0)
            {
                delayInfobox.Text = "Le délai estimé est de ";
            }
            
        }

        private void orderPageBtn_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelDelay.Visible = false;
            panelRecap.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string recap = recapTxt.Text;
            int quantity = Int32.Parse(quantityBox.Text);
            string model = modelBox.Text;
            string size = sizeBox.Text;
            string color = colorBox.Text;
    
            if (modelBox.Text == "Adventure")
            {
                recap += model + ":   " + size + '_' + color + "_ 150€ x " + quantity + " piece(s)" +'\n';
                recapTxt.Text = recap;
                totalPrice += quantity * 150;
                totalPriceTxt.Text = totalPrice.ToString();
            }
            else if (model =="City"){
                recap += model + ":   " + size + '_' + color + "_ 100€ x " + quantity + " piece(s)" + '\n';
                recapTxt.Text = recap;
                totalPrice += quantity * 100;
                totalPriceTxt.Text = totalPrice.ToString();
            }
            else
            {
                
                recap += model + ":   " + size + '_' + color + "_ 250€ x " + quantity + " piece(s)"+ '\n';
                recapTxt.Text = recap;
                totalPrice += quantity * 250;
                totalPriceTxt.Text = totalPrice.ToString();
            }

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            recapTxt.Text = "";
            totalPrice = 0;
            totalPriceTxt.Text= totalPrice.ToString();
           

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // doit retirer la commande de la bdd
        }
    }
}
