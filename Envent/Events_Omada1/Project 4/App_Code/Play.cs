using Project_4.User_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code
{
    class Play
    {
        private Event ev;
        private Venue venue;
        private static List<DateTime> dates = new List<DateTime>();
        private bool status;

        public Play(int eventID) {
            enventDataSetTableAdapters.playTableAdapter pla = new enventDataSetTableAdapters.playTableAdapter();
            List<enventDataSet.playRow> res = pla.getPlay(eventID).ToList();
            for (int i = 0; i < res.Count; i++)
            {
                DateTime date = res.ElementAt(i).date;
                dates.Add(date);
            }
        }

        public List<DateTime> GetDates()
        {
            List<DateTime> dt = new List<DateTime>();
            foreach(DateTime i in dates)
            {
                dt.Add(i.Date);
            }
            return dt;
        }
    }
}
