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
        DataTable StockTable = new DataTable("");
        DataTable CityTable = new DataTable("City");
        DataTable ExplorerTable = new DataTable("Explorer");
        DataTable AdventureTable = new DataTable("Adventure");
        DataTable PartsToOrderTable = new DataTable("PartsToOrder");

        List<DataTable> listDataTables= new List<DataTable>();
        
        public Form1()
        {
            InitializeComponent();
            if (cn.State == ConnectionState.Closed) { cn.Open(); };
            Stock(PartsToOrderTable);
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (user.Text.Length != 0 && password.Text.Length != 0)
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); };
                MySqlCommand command = new MySqlCommand("SELECT * FROM Manager", cn);
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                if (data.Rows.Count != 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        string userDB = row.Field<string>("user");
                        string passwordDB = row.Field<string>("password");

                        if (userDB == user.Text && passwordDB == password.Text)
                        {
                            Console.WriteLine("Connected");
                            connectionPanel.Visible = false;
                        }
                        else if (userDB == user.Text && passwordDB != password.Text)
                        {
                            connectTxt.Text = "Wrong password";
                        }
                        else
                        {
                            connectTxt.Text = "Wrong user";
                        }
                    }
                }
                else
                {
                    connectTxt.Text = "No agent in the database";
                }
            }
            else
            {
                connectTxt.Text = "Complete all the cases";
            }
        }
        private DataTable Stock(DataTable table)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM {0}Stock", table.TableName), cn);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            stockGrid.DataSource = dt;
            return dt;
        }
        private void copyTables(List<DataTable> listDt )
        {
            listDt.Clear();

            listDt.Add(StockTable);
            listDt.Add(CityTable);
            listDt.Add(ExplorerTable);
            listDt.Add(AdventureTable);
            listDt.Add(PartsToOrderTable);

            StockTable = Stock(StockTable);
            CityTable = Stock(CityTable);
            ExplorerTable = Stock(ExplorerTable);
            AdventureTable = Stock(AdventureTable);
            PartsToOrderTable = Stock(PartsToOrderTable);
        }
        private void refillMinimum()
        {
            copyTables(listDataTables);
            foreach (DataRow row in PartsToOrderTable.Rows)
            {
                string name = row.Field<string>("name");
                string type = row.Field<string>("Type");
                string color = row.Field<string>("Color");
                string size = row.Field<string>("Size");

                foreach(DataTable table in listDataTables)
                {
                    if (type == table.TableName)
                    {
                        foreach (DataRow rowT in table.Rows)
                        {
                            //rowCity["quantity"] += row[]
                            Console.WriteLine(rowT["quantity"]);
                        }

                    }
                }
            }

        }
        private void general_Click(object sender, EventArgs e)
        {
            Stock(StockTable);
        }

        private void city_Click(object sender, EventArgs e)
        {
            Stock(CityTable);
        }

        private void explorer_Click(object sender, EventArgs e)
        {
            Stock(ExplorerTable);
        }

        private void adventure_Click(object sender, EventArgs e)
        {
            Stock(AdventureTable);
        }
        private void refillMin_Click(object sender, EventArgs e)
        {
            refillMinimum();
        }
        private void refillAll_Click(object sender, EventArgs e)
        {
            decimal general = generalList.Value;
            decimal city = cityList.Value;
            decimal explorer = explorerList.Value;
            decimal adventure  = adventureList.Value;

            Console.WriteLine(general);
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM PartsToOrder"), cn);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {

                }
            }
            else
            {
                Console.WriteLine("Already filled");
            }

            StockTable.Reset();
            CityTable.Reset();
            ExplorerTable.Reset();
            AdventureTable.Reset();
        }

    }
}
