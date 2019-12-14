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
using Project_4.App_Code.StaticMethods;
namespace Project_4.App_Code.StaticMethods
{
    class Events
    {
        static enventDataSetTableAdapters.eventsTableAdapter eve = new enventDataSetTableAdapters.eventsTableAdapter();
        static List<enventDataSet.eventsRow> eveList = new List<enventDataSet.eventsRow>();
        public static List<string> eventsTitle = new List<string>();


        public static void FillEventsData(){
            eveList = eve.getEvents().ToList();
            for (int i = 0; i < eveList.Count; i++)
            {
                eventsTitle.Add(eveList.ElementAt(i).title);
            }
        }
}
}
