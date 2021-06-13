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
        DataTable StockTable = new DataTable("General");
        DataTable CityTable = new DataTable("City");
        DataTable ExplorerTable = new DataTable("Explorer");
        DataTable AdventureTable = new DataTable("Adventure");
        DataTable PartsToOrderTable = new DataTable("PartsToOrder");
        List<DataTable> listDataTables= new List<DataTable>();
        public Form1()
        {
            InitializeComponent();
            if (cn.State == ConnectionState.Closed) { cn.Open(); };
            copyTables(listDataTables);
            if (PartsToOrderTable.Rows.Count != 0)
            {
                stockGrid.DataSource = PartsToOrderTable;
                info.Text = "Please make sure to order the minimal stock";
            }
            else
            {
                info.Text = "All necessary parts are available";
            }
            user.Text = "thierry";
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
                            connectTxt.Text = "Wrong password : Try again";
                        }
                        else
                        {
                            connectTxt.Text = "Wrong user: Try again";
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
        private DataTable StockRender(DataTable table)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM {0}Stock", table.TableName), cn);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
        }
        private void copyTables(List<DataTable> listDt )
        {
            listDt.Clear();
            
            StockTable = StockRender(StockTable).Copy();
            StockTable.TableName = "General";
            CityTable = StockRender(CityTable).Copy();
            CityTable.TableName = "City";
            ExplorerTable = StockRender(ExplorerTable).Copy();
            ExplorerTable.TableName = "Explorer";
            AdventureTable = StockRender(AdventureTable).Copy();
            AdventureTable.TableName = "Adventure";
            PartsToOrderTable = StockRender(PartsToOrderTable).Copy();
            PartsToOrderTable.TableName = "PartsToOrder";

            listDt.Add(StockTable);
            listDt.Add(CityTable);
            listDt.Add(ExplorerTable);
            listDt.Add(AdventureTable);
            listDt.Add(PartsToOrderTable);
        }
        private void refillMinimum()
        {
            copyTables(listDataTables);
            if(PartsToOrderTable.Rows.Count != 0)
            {
                foreach (DataRow row in PartsToOrderTable.Rows)
                {
                    string name = row.Field<string>("name");
                    string type = row.Field<string>("Type");
                    string color = row.Field<string>("Color");
                    string size = row.Field<string>("Size");
                    int quantity = row.Field<int>("quantity");

                    foreach (DataTable table in listDataTables)
                    {
                        if (table.TableName != "PartsToOrder" && type == table.TableName)
                        {
                            foreach (DataRow rowT in table.Rows)
                            {
                                string nameT = rowT.Field<string>("name");
                                string typeT = table.TableName;
                                int quantityT = rowT.Field<int>("quantity");

                                if (typeT != "General")
                                {
                                    string colorT = rowT.Field<string>("Color");
                                    string sizeT = rowT.Field<string>("Size");
                                    if (name == nameT && type == typeT && color == colorT && size == sizeT)
                                    {
                                        rowT["quantity"] = quantityT + quantity;
                                    }
                                }
                                else 
                                { 
                                    rowT["quantity"] = quantityT + quantity;
                                }

                            }
                        }

                    }
                }
                info.Text = "You ordered the minimal stock required";
            }
            else
            {
                PartsToOrderTable.Reset();
                info.Text = "No need to order anything";
            }
        }
        private void refillMedium()
        {
            refillMinimum();
            foreach (DataTable table in listDataTables)
            {
                foreach (DataRow rowT in table.Rows)
                {
                    int quantityT = rowT.Field<int>("quantity");
                    rowT["quantity"] = quantityT + 20;
                }
            }
            generalList.Value = 20;
            cityList.Value = 20;
            explorerList.Value = 20;
            adventureList.Value = 20;
            info.Text = "You will order 20 parts of everyting";
        }
        private void refillLarge()
        {
            refillMinimum();
            foreach (DataTable table in listDataTables)
            {
                foreach (DataRow rowT in table.Rows)
                {
                    int quantityT = rowT.Field<int>("quantity");
                    rowT["quantity"] = quantityT + 50;
                }
            }
            generalList.Value = 50;
            cityList.Value = 50;
            explorerList.Value = 50;
            adventureList.Value = 50;
            info.Text = "You will order 50 parts of everyting";
        }

        private void refillAllStocks()
        {
            refillMinimum();

            Dictionary<string, decimal> dictValues = new Dictionary<string, decimal>();

            decimal general = generalList.Value;
            decimal city = cityList.Value;
            decimal explorer = explorerList.Value;
            decimal adventure = adventureList.Value;
            string msg = "You will order the minimum stock and in addition for all parts : \n";

            dictValues["General"] = general;
            dictValues["City"] = city;
            dictValues["Explorer"] = explorer;
            dictValues["Adventure"] = adventure;

            foreach (DataTable table in listDataTables)
            {
                if (dictValues.ContainsKey(table.TableName))
                {
                    foreach (DataRow rowT in table.Rows)
                    {
                        int quantityT = rowT.Field<int>("quantity");
                        rowT["quantity"] = quantityT + dictValues[table.TableName];
                    }
                    msg += String.Format("\t{0} : {1} /", table.TableName, dictValues[table.TableName]);
                }
            }
            info.Text = msg;
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            foreach(DataTable table in listDataTables)
            {
                if (table.TableName != "PartsToOrder")
                {
                    string Query = String.Format("Select * from {0}Stock", table.TableName);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Query, cn);
                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(adapter);
                    adapter.Update(table);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(String.Format("TRUNCATE TABLE {0}Stock", table.TableName), cn);
                    cmd.ExecuteNonQuery();
                }
                table.Reset();
            }
            info.Text = "Order done";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            foreach (DataTable table in listDataTables)
            {
                table.Reset();
            }

            listDataTables.Clear();
            info.Text = "";
            generalList.Value = 0 ;
            cityList.Value = 0;
            explorerList.Value = 0;
            adventureList.Value = 0;
        }
        private void general_Click(object sender, EventArgs e)
        {
            stockGrid.DataSource = StockTable;
        }

        private void city_Click(object sender, EventArgs e)
        {
            stockGrid.DataSource = CityTable;
        }

        private void explorer_Click(object sender, EventArgs e)
        {
            stockGrid.DataSource = ExplorerTable;
        }

        private void adventure_Click(object sender, EventArgs e)
        {
            stockGrid.DataSource = AdventureTable;
        }
        private void refillMin_Click(object sender, EventArgs e)
        {
            refillMinimum();
            stockGrid.DataSource = PartsToOrderTable;
        }

        private void refillAll_Click(object sender, EventArgs e)
        {
            refillAllStocks();
            stockGrid.DataSource = StockTable;
        }

        private void mediumRefill_Click(object sender, EventArgs e)
        {
            refillMedium();
            stockGrid.DataSource = StockTable;
        }

        private void largeRefill_Click(object sender, EventArgs e)
        {
            refillLarge();
            stockGrid.DataSource = StockTable;

        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            connectionPanel.Visible = true;
            password.Text = "";

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            copyTables(listDataTables);
            stockGrid.DataSource = StockTable;
            generalList.Value = 0;
            cityList.Value = 0;
            explorerList.Value = 0;
            adventureList.Value = 0;
        }
    }
}
