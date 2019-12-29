using Project_4.App_Code.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code
{
    class Ticket
    {
        private int id;
        private String type;
        private float price;


        public Ticket()
        {
        }

        public Ticket(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.ticketsTableAdapter ev = new enventDataSetTableAdapters.ticketsTableAdapter();
            if (Convert.ToInt32(ev.tryTicket(this.id)) > 0)
            {
                
                List<enventDataSet.ticketsRow> ticketDetails = ev.GetTicket(this.id).ToList();
                this.type = ticketDetails.ElementAt(0).type;
                this.price = ticketDetails.ElementAt(0).price;

            }
            else
            {
                throw new TicketException("Το Ticket δεν υπάρχει");
            }
        }
        public int GetId()
        {
            return id;
        }
        
        public string GetType()
        {
            return type;
        }

        public float GetPrice()
        {
            return price;
        }

    }
}
