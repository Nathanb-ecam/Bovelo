using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class Form1 : Form
    {
        int totalPrice = 0;
        int nbrBikeAdv = 0;
        int nbrBikeCity = 0;
        int nbrBikeExpl = 0;

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
        private void orderBikeBuilder(Type model, Size size, Color color,int price, int quantity)
        {
            for (int value= 0; value < quantity; value++)
            {
                Bike bike_name = new Bike(model,size,color,price);
                Console.WriteLine(bike_name.IdBike);
                Console.WriteLine(bike_name.Price);
            }

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
            int bikeSize = Int32.Parse(size.Substring(0,2));
            Type t = new Type(model);
            Color c = new Color(color);
            Size s = new Size(bikeSize);
            int price = 0;

            if (model== "Adventure")
            {
                nbrBikeAdv += quantity;
                price = 150;
               
                orderBikeBuilder(t,s,c,price,quantity);
               

             
                totalPrice += quantity * 150;
                totalPriceTxt.Text = totalPrice.ToString();
            }
            else if (model =="City"){
                nbrBikeCity += quantity;
                price = 100;
                
                orderBikeBuilder(t, s, c, price, quantity);
                
                
                totalPrice += quantity * 100;
                totalPriceTxt.Text = totalPrice.ToString();
            }
            else if(model =="Explorer")
            {
                nbrBikeExpl += quantity;
                price = 250;
                
                orderBikeBuilder(t, s, c, price, quantity);
          
                
                totalPrice += quantity * 250;
                totalPriceTxt.Text = totalPrice.ToString();
            }
            recap += String.Format("{0}: {1}{2}{3}€ x {4} piece(s)+ '\n'", model, size,color,price,quantity);
            recapTxt.Text = recap;


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
