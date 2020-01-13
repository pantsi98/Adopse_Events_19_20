using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Globalization;
namespace Project_4
{
    public partial class BookingStep2 : UserControl
    {
        int user_id;
        int event_id;
        DateTime event_date;
        DateTime date_new;
        string date_string;
        int normal_tickets_count;
        int reduced_tickets_count;
        public BookingStep2()
        {

            InitializeComponent();
        }
        public BookingStep2(int id, DateTime date, string pay_type, int normal, int reduced)
        {

            InitializeComponent();
            //pairno to event	
            Event ev = new Event(id);
            event_id = id;
            event_date = date;
            date_string = event_date.ToString("yyyy-MM-dd HH:mm:ss");
            date_new = Convert.ToDateTime(date_string);

            //pairno ta tickets	
            enventDataSetTableAdapters.ticketsTableAdapter tick = new enventDataSetTableAdapters.ticketsTableAdapter();
            float normal_ticket_price = (float)tick.GetNormalPriceEventId(id);
            float reduced_ticket_price = (float)tick.GetReducedPriceEventId(id);
            User x = InstanceOfUser.GetUser();
            Debug.WriteLine(x);
            if (x is Project_4.App_Code.NormalUser)
            {
                NormalUser nr = (NormalUser)x;
                name_label.Text = nr.GetProfile().GetLastName() + " " + nr.GetProfile().GetFirstName();
                user_id = nr.GetUserID();
            }

            PlayTitle_label.Text = ev.GetTitle();
            date_label.Text = date.ToString();
            normalTickets_Label.Text = normal.ToString();
            reducedTickets_Label.Text = reduced.ToString();
            label5.Text += "(" + normal_ticket_price + "€) :";
            label7.Text += "(" + reduced_ticket_price + "€) :";
            float total_price = normal_ticket_price * normal + reduced_ticket_price * reduced;
            total_Price.Text = total_price.ToString();
            normal_tickets_count = normal;
            reduced_tickets_count = reduced;
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            
                enventDbDataSetTableAdapters.reservationsTableAdapter rsv = new enventDbDataSetTableAdapters.reservationsTableAdapter();
            rsv.createRsv(user_id, event_id, date_new, normal_tickets_count, reduced_tickets_count);
            if (MessageBox.Show("Η κράτηση πραμγατοποιήθηκε επιτυχώς!", "Επιτυχής κράτηση", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Control parent = this.Parent;
                    while (parent.Name != "MainPanel")
                    {
                        Debug.WriteLine(parent.Name);
                        parent = parent.Parent;
                    }
                    parent.Controls.Clear();
                    parent.Controls.Add(new HomeMain());
                }
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Η κράτηση δεν πραγματοποιήθηκε! Παρακαλώ ξαναδοκιμάστε.", "Μη επιτυχής κράτηση", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
    }
}