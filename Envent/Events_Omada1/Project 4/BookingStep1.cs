using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.User_Classes;
using Project_4.App_Code;
using System.Diagnostics;

namespace Project_4
{
    public partial class BookingStep1 : UserControl
    {
        int event_id;
        string payment_type;
        int normal_tickets;
        int reduced_tickets;
        string date;
        public BookingStep1()
        {
          //  InitializeComponent();

        }

        public BookingStep1(int id)
        {
            InitializeComponent();
            this.event_id = id;

            Event ev1 = new Event(id);
            play_title.Text = ev1.GetTitle();
            Play pl1 = new Play(id);
            List<DateTime> dates = pl1.GetDates();
            
            foreach (DateTime date in dates)
            {
                if (!dateComboBox.Items.Contains(date))
                {
                    dateComboBox.Items.Add(date);
                }
                
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            date = dateComboBox.SelectedItem.ToString();
            payment_type = paymentComboBox.SelectedItem.ToString();
            normal_tickets = (int)normalTicketsCounter.Value;
            reduced_tickets = (int)reducedTicketsCounter.Value;

            BookingStep2 b2 = new BookingStep2(event_id ,date, payment_type, normal_tickets, reduced_tickets);
            Control parent = this.Parent;
            while (parent.Name != "MainPanel")
            {
                parent = parent.Parent;
            }
            parent.Controls.Clear();
            parent.Controls.Add(b2);
        }
    }
}

