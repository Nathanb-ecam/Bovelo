using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace BOVELO_PlanningList
{
    class LocationParts
    {
        MySqlConnection cn;

        CommonParts a = new CommonParts();
        CityParts b = new CityParts();
        ExplorerParts c = new ExplorerParts();
        AdventureParts d = new AdventureParts();
        SizeParts e = new SizeParts();

        private List<string> allCommonParts = new List<string>();
        private List<string> allCityParts = new List<string>();
        private List<string> allExplorerParts = new List<string>();
        private List<string> allAdventureParts = new List<string>();

        private string locationCommon;
        private string locationCity;
        private string locationExplorer;
        private string locationAdventure;
        

        public List<string> getCommonParts()
        {            
            allCommonParts.AddRange(a.getList_Nbr1());
            allCommonParts.AddRange(a.getList_Nbr2());
            allCommonParts.AddRange(a.getList_Nbr4());

            allCommonParts.AddRange(e.getList_Nbr1());
            allCommonParts.AddRange(e.getList_Nbr2());

            return allCommonParts;
        }

        public List<string> getCityParts()
        {
            allCityParts.AddRange(b.getList_Nbr1());
            allCityParts.AddRange(b.getList_Nbr2());
            allCityParts.AddRange(b.getList_Nbr1_SSCT());           

            return allCityParts;
        }

        public List<string> getExplorerParts()
        {
            allExplorerParts.AddRange(c.getList_Nbr1());
            allExplorerParts.AddRange(c.getList_Nbr2());
            allExplorerParts.AddRange(c.getList_Nbr1_SSCT());

            return allExplorerParts;
        }
        public List<string> getAdventureParts()
        {
            allAdventureParts.AddRange(d.getList_Nbr1());
            allAdventureParts.AddRange(d.getList_Nbr2());

            return allAdventureParts;
        }

        public string getCommonLocation()
        {
            cn = new MySqlConnection("server=193.191.240.67;user=nick;database=DataBase;port=63307;password=1234");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            MySqlCommand command = new MySqlCommand("SELECT * From Stock WHERE Quantity>min ", cn);            
            using (MySqlDataReader Lire = command.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string locationCommon = Lire["Location"].ToString();
                    return locationCommon;    
                }
            }
            cn.Close();

            return locationCommon;
        }

        public string getCityLocation()
        {
            cn = new MySqlConnection("server = 193.191.240.67; user = nick; database = DataBase; port = 63307; password = 1234");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            MySqlCommand command = new MySqlCommand("SELECT * From CityStock WHERE Quantity>min ", cn);
            using (MySqlDataReader Lire = command.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string locationCity = Lire["Location"].ToString();
                    return locationCity;
                }
            }
            cn.Close();

            return locationCity;
        }
        public string getExplorerLocation()
        {
            cn = new MySqlConnection("server = 193.191.240.67; user = nick; database = DataBase; port = 63307; password = 1234");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            MySqlCommand command = new MySqlCommand("SELECT * From ExplorerStock WHERE Quantity>min ", cn);
            using (MySqlDataReader Lire = command.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string locationExplorer = Lire["Location"].ToString();
                    return locationExplorer;
                }
            }
            cn.Close();

            return locationExplorer;
        }
        public string getAdventureLocation()
        {
            cn = new MySqlConnection("server = 193.191.240.67; user = nick; database = DataBase; port = 63307; password = 1234");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            MySqlCommand command = new MySqlCommand("SELECT * From AdventureStock WHERE Quantity>min ", cn);
            using (MySqlDataReader Lire = command.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string locationAdventure = Lire["Location"].ToString();
                    return locationAdventure;
                }
            }
            cn.Close();

            return locationAdventure;
        }


    }
}
