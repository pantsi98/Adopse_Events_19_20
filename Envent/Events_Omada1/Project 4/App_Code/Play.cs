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
        private DateTime date;
        private bool status;

        public Play(int eventID) {
            enventDataSetTableAdapters.playTableAdapter pla = new enventDataSetTableAdapters.playTableAdapter();
            List<enventDataSet.playRow> res = pla.getPlay(eventID).ToList();
            this.date = res.ElementAt(0).date;
            this.status = res.ElementAt(0).status;
        }
    }
}
