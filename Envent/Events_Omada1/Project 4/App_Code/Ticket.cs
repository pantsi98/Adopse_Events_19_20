﻿using Project_4.App_Code.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_4.App_Code
{
    class Ticket
    {
        private int id;
        private String type;
        private int price;
        private int play_id;


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
        public void CreateTicket(string type,int price, int play_id)
        {
            try
            {
                enventDataSetTableAdapters.ticketsTableAdapter tick = new enventDataSetTableAdapters.ticketsTableAdapter();

                this.type = type;
                this.price = price;
                this.play_id = play_id;
                tick.createTicket(type, price, play_id);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
