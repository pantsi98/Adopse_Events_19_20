using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code
{
    class Reservation
    {
        int id;
        int user_id;
        int event_id;
        string payment_type;
        DateTime date;

        public Reservation(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.reservationsTableAdapter rsvr = new enventDataSetTableAdapters.reservationsTableAdapter();
            if (Convert.ToInt32(rsvr.tryReservation(this.id)) > 0)
            {
                List<enventDataSet.reservationsRow> reservationDetails = rsvr.GetReservation(this.id).ToList();
                this.id = reservationDetails.ElementAt(0).id;
                this.user_id = reservationDetails.ElementAt(0).user_id;
                this.event_id = reservationDetails.ElementAt(0).event_id;
                this.payment_type = reservationDetails.ElementAt(0).payment_type;
                this.date = reservationDetails.ElementAt(0).date;
            }
        }

        public int GetId()
        {
            return id;
        }
        public int GetUserId()
        {
            return user_id;
        }

        public int GetEventId()
        {
            return event_id;
        }
        public string GetPaymentType()
        {
            return payment_type;
        }
        public DateTime GetDate()
        {
            return date;
        }
    }




}
