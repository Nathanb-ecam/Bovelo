using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bovelo
{
    public partial class Form1 : Form
    {
        int totalPrice = 0;
        Order order = new Order(1, new Dictionary<Bike, int>());

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
        private void orderBikeBuilder(Type model, Size size, Color color, int quantity)
        {
            for (int value= 0; value < quantity; value++)
            {
                Bike bike_name = new Bike(model,size,color,model.Price);
                order.AddBike(bike_name, value);
                Console.WriteLine(order.ToString());
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
            string recap = "";
            string model = modelBox.Text;
            string size = sizeBox.Text;
            string color = colorBox.Text;
            string bikeRef = model.Substring(0, 1) + color.Substring(0, 1) + size.Substring(0, 2);

            int bikeSize = Int32.Parse(size.Substring(0,2));
            int quantity = Int32.Parse(quantityBox.Text);

            Type t = new Type(model);
            Color c = new Color(color);
            Size s = new Size(bikeSize);

            if (model== "Adventure" || model == "Explorer" || model == "City")
            {
                orderBikeBuilder(t,s,c,quantity);
                recap = order.GetNumBike(t).ToString();
            }

            totalPrice += quantity * t.Price;

            
            totalPriceTxt.Text = totalPrice.ToString();
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

        private void panelDelay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
