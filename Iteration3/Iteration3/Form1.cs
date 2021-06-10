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
            Stock();
        }


        private void Stock()
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM PartsToOrder"), cn);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
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
                MySqlCommand cmd = new MySqlCommand(String.Format("Update PartsToOrder SET name = @name, quantity=@quantity where name=@name", name), cn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
