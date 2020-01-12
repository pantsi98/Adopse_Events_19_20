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
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;
using System.Diagnostics;

namespace Project_4
{
    public partial class BookingStep2 : UserControl
    {
        public BookingStep2()
        {
            InitializeComponent();
        }

        public BookingStep2(int id, string date, string pay_type, int normal , int reduced)
        {
            
                InitializeComponent();
                //pairno titlo tou event
                Event ev = new Event(id);
                //pairno ta tickets
                enventDataSetTableAdapters.ticketsTableAdapter tick = new enventDataSetTableAdapters.ticketsTableAdapter();
                float normal_ticket_price = (float)tick.GetNormalPriceEventId(id);
                float reduced_ticket_price = (float)tick.GetReducedPriceEventId(id);


            User x = InstanceOfUser.GetUser();
            Debug.WriteLine(x);
            if(x is Project_4.App_Code.NormalUser) {
                NormalUser nr = (NormalUser)x;
                name_label.Text = nr.GetProfile().GetLastName() + " " + nr.GetProfile().GetFirstName();
            }
                
            PlayTitle_label.Text = ev.GetTitle();
            date_label.Text = date;
            normalTickets_Label.Text = normal.ToString();
            reducedTickets_Label.Text = reduced.ToString();
            label5.Text += "(" + normal_ticket_price + "€) :";
            label7.Text += "(" + reduced_ticket_price + "€) :";

            float total_price = normal_ticket_price * normal + reduced_ticket_price * reduced;
            total_Price.Text = total_price.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PlayTitle_label_Click(object sender, EventArgs e)
        {

        }
    }
}
