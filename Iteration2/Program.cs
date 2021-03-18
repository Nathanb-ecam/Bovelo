using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BOVELO_PlanningList
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}

//private void create_bike_dict(Dictionary<string, int> dict)
//{
//    //We should integrate the DataBase table instead of this path
//    string[] lines = File.ReadAllLines(@"C:\Users\khale\source\repos\Bovelo\BovéloOrderInterface\bikes_list.txt");

//    foreach (string line in lines)
//    {
//        dict[line] = 0;
//    }

//}

//foreach (KeyValuePair<string, int> entry in bikes_dict)
//{
//    if (entry.Value != 0)
//    {
//        recap += String.Format("{0} :    {1} piece(s)    {2} $ \n", entry.Key, entry.Value, entry.Value * t.Price);
//    }
//}