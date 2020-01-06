using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code;
using Project_4.User_Classes;
using Project_4.App_Code.StaticMethods;
namespace Project_4
{
    public partial class CreateNewEvent : UserControl
    {
        User uem = InstanceOfUser.GetUser();

        int event_id;
        int venue_id;
        Ticket t1, t2;

        public CreateNewEvent()
        {
            InitializeComponent();
            //gemisma ton topothesion
            Venue vn = new Venue();
            List<String> venues = new List<String>();
            venues = vn.getAllVenues();
           
            topothesia.Items.AddRange(vn.getAllVenues().ToArray());
        }

        public int Id;
      

        private void CreateNewEvent_Load(object sender, EventArgs e)
        {
            Addplay.Enabled = false;
            createEvent.Enabled = false;
         
        }
        

       
        Boolean deiktislathwnPlay;

        private Boolean cheackallPlay()
        {
            deiktislathwnPlay = true;
            if(topothesia.Text=="")
                deiktislathwnPlay = false;
            else if (kanonikoticket.Value==0)
                deiktislathwnPlay = false;
            else if (meiomenoticket.Value == 0)
                deiktislathwnPlay = false;

            return deiktislathwnPlay;

        }


        Boolean deiktislathwn;
        private Boolean checkall()
        {
            //den exei ginei elegxos gia eikona
            deiktislathwn = true;
            if (titlos.Text == "")
                deiktislathwn = false;
            else if (perigrafi.Text == "")
                deiktislathwn = false;
            else if (durationhour.Value == 0 )
                deiktislathwn = false;
            else if (katigoria.Text == "")
                deiktislathwn = false;
            else if(urlimage.Text=="")
                deiktislathwn = false;

            return deiktislathwn;
        }

        private void CreateNewEvent_MouseHover(object sender, EventArgs e)
        {
            if (!checkall())
            {
                createEvent.Enabled = false;
                
            }
            else
            {
                createEvent.Enabled = true;
            }
        }

        int kat;
        //methodos gia na dinei to swsto id stin katigoria
        private int katigoriacomboboxselect()
        {

            if (katigoria.SelectedValue == "Music")
                kat = 1;
            else if (katigoria.SelectedValue == "Theater")
                kat = 2;
            else if (katigoria.SelectedValue == "Conference")
                kat = 3;
            else if (katigoria.SelectedValue == "Festivals")
                kat = 4;
            else if (katigoria.SelectedValue == "Sports")
                kat = 5;
            else if (katigoria.SelectedValue == "Educational")
                kat = 6;
            else if (katigoria.SelectedValue == "Informing")
                kat = 7;
            else if (katigoria.SelectedValue == "Soccer")
                kat = 8;
            else if (katigoria.SelectedValue == "Basketball")
                kat = 9;
            else if (katigoria.SelectedValue == "Cinema")
                kat = 10;

            return kat;
        }

        private int selectedduration()
        {
            int hour = Convert.ToInt32(Math.Round(durationhour.Value));
            //se lepta
            return hour * 60 ;

        }
        private void eventCreatedui()
        {
            //enable ta textbox 
            titlos.Enabled = false;
            katigoria.Enabled = false;
            durationhour.Enabled = false;
            urlimage.Enabled = false;
            createEvent.Enabled = false;
            createEvent.Enabled = false;
            createplaypanel.Visible = true;
            
        } 

        private void createEvent_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
           EventManager em = (EventManager)uem;
            try
            {

                em.CreateEvent(titlos.Text, katigoriacomboboxselect(), perigrafi.Text, selectedduration(), urlimage.Text);
                event_id = em.GetEventIdByTtitle(titlos.Text);
                eventCreatedui();
            }
            catch (Exception msg) {
                label2.Visible = true;
                label2.Text = "H δημιουργία Event απέτυχε";
            }
            
        }

     
        private void Addplay_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            EventManager em = (EventManager)uem;
            string location_combobox_text = topothesia.SelectedItem.ToString();
          
            DateTime mydate = dateofPlay.Value.Date + timepicker.Value.TimeOfDay;
            try
            {
                enventDataSetTableAdapters.venuesTableAdapter vn = new enventDataSetTableAdapters.venuesTableAdapter();
                venue_id = vn.GetVenueIdFromVenueName(location_combobox_text).GetValueOrDefault();
               int  play_id=em.CreatePlay(event_id, venue_id, mydate);


                int normalticket = Convert.ToInt32(kanonikoticket.Value);
                int reducedticket = Convert.ToInt32(meiomenoticket.Value);

                try {
                    
                    t1.CreateTicket("normal", normalticket, play_id);
                    t2.CreateTicket("reduced", reducedticket, play_id);
                    
                    //emfanisi se listview
                    String date1 = mydate.ToString();
                    String kan = kanonikoticket.Value.ToString();
                    String top = topothesia.Text;
                    String meiom = meiomenoticket.Value.ToString();
                    ListViewItem item = new ListViewItem(new[] { date1, top, kan, meiom });
                    listView1.Items.Add(item);

                } catch (Exception msg) {
                    label2.Visible = true;
                    label2.Text = "H δημιουργία εισιτηρίου απέτυχε";
                } 

            }
            catch (Exception msg) {
                label2.Visible = true;
                label2.Text = "H δημιουργία παραστασης απέτυχε";
            }

           


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletePlay_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }


        }

        private void createplaypanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void createplaypanel_MouseHover(object sender, EventArgs e)
        {
            if (!cheackallPlay())
            {
               Addplay.Enabled = false;
            }
            else
            {
                Addplay.Enabled = true;
            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           

        }
    }
}
