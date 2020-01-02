using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code.StaticMethods;
using System.Net;
using System.IO;
using Project_4.User_Classes;
using Project_4.App_Code;
using System.Diagnostics;

namespace Project_4
{
    public partial class EventFullDescription : UserControl
    {
        int event_id;
        int k = 1;
        public EventFullDescription()
        {
            InitializeComponent();
        }

        public EventFullDescription(int id)
        {
            InitializeComponent();
            PrepareElements(id);
            User x = InstanceOfUser.GetUser();
            if (x is NormalUser)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
                button8.BackColor = Color.LightSlateGray;
            }
            event_id = id;
        }

        String description;
        String title;
        


        private void PrepareElements(int id)
        {

            //pairno to venue 
            enventDataSetTableAdapters.venuesTableAdapter ven = new enventDataSetTableAdapters.venuesTableAdapter();
            int venue_id = (int)ven.GetVenueIdFromEventID(id);
            Venue theVenue = new Venue(venue_id);

            //pairno ta tickets
            enventDataSetTableAdapters.ticketsTableAdapter tick = new enventDataSetTableAdapters.ticketsTableAdapter();
            float normal_ticket = (float)tick.GetNormalPriceEventId(id);
            float reduced_ticket = (float)tick.GetReducedPriceEventId(id);


            User_Classes.Event event_kati = new User_Classes.Event(id);
            App_Code.Play plays = new App_Code.Play(id);


            Dictionary<int, string> category = new Dictionary<int,string>();
            category[1] = "Music"; category[2] = "Theater"; category[3] = "Conference"; category[4] = "Festivals"; category[5] = "Sports"; category[6] = "Educational"; category[7] = "Informing"; category[8] = "Soccer"; category[9] = "Basketball"; category[10] = "Cinema";
            int cat_id = event_kati.GetCategory();
            string cat_name = category[cat_id];
            int duration = event_kati.GetDuration();
            
            this.eventTitle.Text = event_kati.GetTitle();
            this.imerominia.Text = event_kati.GetCreatedAt().ToString("d/M/yyyy");
            this.perigrafilabel.Text = event_kati.GetDescription().ToString();
            this.durationlabel.Text = (duration / 3600).ToString() + " ώρες";
            this.categorylabel.Text = cat_name;
            this.topothesia.Text = theVenue.GetName();
            this.NameofPlace.Text = theVenue.GetName();
            this.addressofPlace.Text = theVenue.GetLocation();
            this.kanonikoTimi.Text = normal_ticket.ToString();
            this.meiomenoTimi.Text = reduced_ticket.ToString();
            //Debug.WriteLine(event_kati.GetTitle().ToString());
            Image rszimg = Images.resizeImage(Images.pic.ElementAt(id), new Size(880, 222));
            IconEvent.Image = rszimg;

            int z = 0;

            List<DateTime> dates = plays.GetDates();
            foreach (DateTime date in dates)
            {

                Label newLabel = new Label();

                newLabel.Width = 125;
                newLabel.Height = 20;
                newLabel.Location = new Point(10, 50 + 2 * z * newLabel.Height);
                newLabel.Name = "label" + z;
                
                newLabel.Text = date.ToString("dd/MM/yyyy HH:mm");
                date_panel.Controls.Add(newLabel);

                
                z++;
            }


        }

        private void EventFullDescription_Load(object sender, EventArgs e)
        {
            try
            {
                //paradeigma fortiseis tou event me id =12
              //  User_Classes.Event event1 = new User_Classes.Event(12);
               // description = event1.GetDescription();
               // title = event1.GetTitle();
              //  duration=event1.GetDuration();
                
                




            }
            catch (User_Classes.Exceptions.EventException msg)
            {
                Cursor.Current = Cursors.Default;
                label10.Text = msg.ToString();

            }



            //Anathesi timwn sta katallila labels
            //String dur = duration.ToString();

           // durationlabel.Text = dur;
            //eventTitle.Text = title;
            //perigrafilabel.Text = description;

        }

        private void book_tab_MouseClick(object sender, MouseEventArgs e)
        {
           
           
            
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BookingStep1 b1 = new BookingStep1(event_id);
            Control parent = this.Parent;
            while (parent.Name != "MainPanel")
            {
                parent = parent.Parent;
            }
            parent.Controls.Clear();
            parent.Controls.Add(b1);
            
        }
    }

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }
    }
}
