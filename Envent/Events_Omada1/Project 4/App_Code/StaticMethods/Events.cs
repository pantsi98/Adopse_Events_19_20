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
using Project_4.User_Classes;
namespace Project_4.App_Code.StaticMethods
{
    public class Events
    {
        static enventDataSetTableAdapters.eventsTableAdapter eve = new enventDataSetTableAdapters.eventsTableAdapter();
        static List<enventDataSet.eventsRow> eveList = new List<enventDataSet.eventsRow>();
        public static List<Event> events= new List<Event>();


        public static void FillEventsData(){
            eveList = eve.getEvents().ToList();
            for (int i = 0; i < eveList.Count; i++)
            {
                Event eventItem = new Event(eveList.ElementAt(i).id, eveList.ElementAt(i).title, eveList.ElementAt(i).category_id, eveList.ElementAt(i).created_at, eveList.ElementAt(i).description, eveList.ElementAt(i).duration, eveList.ElementAt(i).active, eveList.ElementAt(i).img);
                events.Add(eventItem);
            }
        }

        public static List<int> GetIDs()
        {
            List<int> ids = new List<int>();
            foreach(Event e in events)
            {
                ids.Add(e.GetID());
            }
            return ids;
        }

        public static int GetID(string title)
        {
            return events.Find(x => x.GetTitle() == title).GetID();
        }
    }
}
