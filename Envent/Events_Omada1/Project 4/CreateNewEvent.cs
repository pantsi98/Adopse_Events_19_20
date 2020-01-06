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
        Play play =new Play(1);
        int event_id;
        int venue_id;
       
        public CreateNewEvent()
        {
            InitializeComponent();
            //gemisma ton topothesion
            Venue vn = new Venue();
            List<String> venues = new List<String>();
            venues = vn.getAllVenues();
            /*foreach (String x in venues)
            {
                //cmbMovieListingBox.Items.Add(film.GetFilmTitle());
                topothesia.Items.Add(vn.getAllVenues());
            }
            */
            topothesia.Items.AddRange(vn.getAllVenues().ToArray());
        }

        public int Id;
      

        private void CreateNewEvent_Load(object sender, EventArgs e)
        {
            Addplay.Enabled = false;
            createEvent.Enabled = false;
         
        }
        

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);

            }
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
            else if (durationhour.Value == 0 && durationmin.Value == 0)
                deiktislathwn = false;
            else if (katigoria.Text == "")
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
            int min = Convert.ToInt32(Math.Round(durationmin.Value));
            return hour * 60 + min;

        }
        private void eventCreatedui()
        {
            //enable ta textbox 
            titlos.Enabled = true;
            katigoria.Enabled = true;
            durationhour.Enabled = true;
            durationmin.Enabled = true;
            uploadImage.Enabled = true;
            createEvent.Enabled = true;
            createEvent.Enabled = true;
            createplaypanel.Visible = true;
            
        } 

        private void createEvent_Click(object sender, EventArgs e)
        {

            //EventManager em = (EventManager)uem;
           // em.CreateEvent(titlos.Text, katigoriacomboboxselect(), perigrafi.Text, selectedduration());
            //event_id = em.GetEventIdByTtitle(titlos.Text);
            eventCreatedui();
            //edw apotelesma pou an gurizei id event


        }

     
        private void Addplay_Click(object sender, EventArgs e)
        {
            int normalticket = Convert.ToInt32(kanonikoticket.Value);
            int reducedticket = Convert.ToInt32(meiomenoticket.Value);
            //dokimastiko id play
            int play_id=1;
            Ticket tic = new Ticket();
            tic.CreateTicket("normal", normalticket, play_id);
            tic.CreateTicket("reduced", reducedticket, play_id);
            string location_combobox_text = topothesia.SelectedItem.ToString();

            enventDataSetTableAdapters.venuesTableAdapter vn = new enventDataSetTableAdapters.venuesTableAdapter();
            venue_id = vn.GetVenueIdFromVenueName(location_combobox_text).GetValueOrDefault();
            //em.Createplay()..... To do




            ///entoles gia na emfanizei to play poy egine
            

            //dimiourgia enos obj venue gia na parei ola ta names
             

            String date= dateofPlay.Value.ToString("yyyy-MM-dd");
            String time = timepicker.Value.ToString("HH:mm");
            String kan = kanonikoticket.Value.ToString();
            String top = topothesia.Text;
            String meiom = meiomenoticket.Value.ToString();
            ListViewItem item = new ListViewItem(new[] { date, time,top, kan, meiom });
            listView1.Items.Add(item);


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
