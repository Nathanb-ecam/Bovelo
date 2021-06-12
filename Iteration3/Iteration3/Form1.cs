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

namespace Iteration3
{
    public partial class Form1 : Form
    {
        MySqlConnection cn = new MySqlConnection("server=193.191.240.67;user=nick;database=mydb;port=63307;password=1234");
        public Form1()
        {
            InitializeComponent();
            if (cn.State == ConnectionState.Closed) { cn.Open(); };
        }


        private void ShowTable(string table)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM {0}",table), cn);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            // here we want to filter the cases and propose quantity values to help the manager by adding a new colum 'suggestion'
            DataColumn c = new DataColumn();
            c.DataType = typeof(Int32);
            c.ColumnName = "Suggestion";
            dt.Columns.Add(c);

            foreach (DataRow row in dt.Rows)
            {
                // ... A CHANGER ...
                int quantity = Int32.Parse(row["quantity"].ToString());
                int min = Int32.Parse(row["min"].ToString());
                if (quantity < min)
                {
                    row["Suggestion"] = (min-quantity).ToString();
                    
                }            
            }

            // we display the grid with the values
            stockGrid.DataSource = dt;
        }

        private void refillBtn_Click(object sender, EventArgs e)
        {      
            // this part updates Stock table with the values entered
            DataTable dt = (DataTable)stockGrid.DataSource;
            foreach (DataRow row in dt.Rows)

            {
                string name = row["name"].ToString();
                int quantity = Int32.Parse(row["quantity"].ToString());
                string type = row["Type"].ToString();
                string size = row["Size"].ToString();
                string color = row["Color"].ToString();
                MySqlCommand cmd = new MySqlCommand(String.Format("Update {0}Stock SET name = @name, quantity=@quantity where name=@name and color=@color and size=@size and type=@type or name=@name and color=@color and size=null",type), cn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.ExecuteNonQuery();

            }
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            ShowTable((sender as Button).Name);
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string model = modelBox.Text;
            int quantity = Convert.ToInt32(quantityBox.Value);
            Console.WriteLine(model);
            Console.WriteLine(quantity);

            IncreaseQuantity(model,quantity);
        }
        private void IncreaseQuantity(string m, int q)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format("Update {0}Stock SET quantity= quantity+{1}", m,q), cn);
            //cmd.Parameters.AddWithValue("@quantity", q);
            cmd.ExecuteNonQuery();
        }   
    }
}                                                 
