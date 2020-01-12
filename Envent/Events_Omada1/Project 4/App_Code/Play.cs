using Project_4.User_Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code
{
    public class Play
    {
        private static List<DateTime> dates = new List<DateTime>();
        private int ev;
        //private Event ev;
        //private Venue venue;
        private int venue;
        private DateTime date;
        private bool status;

        public List<DateTime> GetDates()
        {
            List<DateTime> dt = new List<DateTime>();
            foreach (DateTime i in dates)
            {
                dt.Add(i.Date.Date);
                Debug.WriteLine(i.Date.Date);
            }
            return dt;
        }
        static enventDataSetTableAdapters.playTableAdapter pla = new enventDataSetTableAdapters.playTableAdapter();
        static List<enventDataSet.playRow> pl = new List<enventDataSet.playRow>();
        public static List<Play> plays = new List<Play>();


        public static void FillPlaysData()
        {
            pl = pla.GetPlays().ToList();
            for (int i = 0; i < pl.Count; i++)
            {
                Play playItem = new Play(pl.ElementAt(i).event_id, pl.ElementAt(i).venue_id, pl.ElementAt(i).date, pl.ElementAt(i).status);
                plays.Add(playItem);
            }
        }

        public Play(int eventID)
        {
            enventDataSetTableAdapters.playTableAdapter pla = new enventDataSetTableAdapters.playTableAdapter();
            List<enventDataSet.playRow> res = pla.getPlay(eventID).ToList();
            this.date = res.ElementAt(0).date;
            this.status = res.ElementAt(0).status;
        }

        public Play(int ev, int venue, DateTime date, bool status)
        {
            this.ev = ev;
            this.venue = venue;
            this.date = date;
            this.status = status;
        }

        public DateTime getDates()
        {
            return this.date;
        }

        public int GetEventID()
        {
            return this.ev;
        }

        public int GetVenueID()
        {
            return this.venue;
        }
    }
}