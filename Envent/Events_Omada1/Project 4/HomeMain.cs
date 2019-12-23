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
namespace Project_4
{
    public partial class HomeMain : UserControl
    {
        public HomeMain()
        {
            InitializeComponent();
        }

        private void HomeMain_Load(object sender, EventArgs e)
        {

            int index = 0;
            User user = InstanceOfUser.GetUser();
            List<Event> events = user.ShowEvents();
            List<Event> musicevents = new List<Event>();
            List<Event> theaterevents = new List<Event>();
            List<Event> conferenceevents = new List<Event>();
            List<Event> festivalsevents = new List<Event>();
            List<Event> sportsevents = new List<Event>();
            List<Event> cinemaevents = new List<Event>();

            foreach (Event ev in events)
            {
                switch (ev.GetCategory())
                {
                    case 1:
                        musicevents.Add(ev);
                        break;
                    case 2:
                        theaterevents.Add(ev);
                        break;
                    case 3:
                    case 6:
                    case 7:
                        conferenceevents.Add(ev);
                        break;
                    case 4:
                        festivalsevents.Add(ev);
                        break;
                    case 5:
                    case 8:
                    case 9:
                        sportsevents.Add(ev);
                        break;
                    case 10:
                        cinemaevents.Add(ev);
                        break;
                }
            }

            foreach (Control p in musicPanel.Controls)
            {
                foreach (Control i in p.Controls)
                {
                    if (index + 1 < musicevents.Count) {
                        if (i is PictureBox)
                        {
                            PictureBox pic = (PictureBox)i;
                            pic.Load(musicevents.ElementAt(index).GetImage());
                        }
                        if (i is Label)
                        {
                            Label lb = (Label)i;
                            lb.Text = musicevents.ElementAt(index).GetTitle();
                        }
                        index++;
                    }
                }
            }
            index = 0;

            foreach (Control p in theaterPanel.Controls)
            {
                foreach (Control i in p.Controls)
                {
                    if (index + 1 < theaterevents.Count) {
                        if (i is PictureBox)
                        {
                            PictureBox pic = (PictureBox)i;
                            pic.Load(theaterevents.ElementAt(index).GetImage());
                        }
                        if (i is Label)
                        {
                            Label lb = (Label)i;
                            lb.Text = theaterevents.ElementAt(index).GetTitle();
                        }
                        index++;
                    }
                }
            }
            index = 0;

            foreach (Control p in conferencePanel.Controls)
            {
                foreach (Control i in p.Controls)
                {
                    if (index + 1 < conferenceevents.Count)
                    {
                        if (i is PictureBox)
                        {
                            PictureBox pic = (PictureBox)i;
                            pic.Load(conferenceevents.ElementAt(index).GetImage());
                        }
                        if (i is Label)
                        {
                            Label lb = (Label)i;
                            lb.Text = conferenceevents.ElementAt(index).GetTitle();
                        }
                        index++;
                    }
                }
            }
            index = 0;

            foreach (Control p in festivalsPanel.Controls)
            {
                foreach (Control i in p.Controls)
                {
                    if (index + 1 < festivalsevents.Count)
                    {
                        if (i is PictureBox)
                        {
                            PictureBox pic = (PictureBox)i;
                            pic.Load(festivalsevents.ElementAt(index).GetImage());
                        }
                        if (i is Label)
                        {
                            Label lb = (Label)i;
                            lb.Text = festivalsevents.ElementAt(index).GetTitle();
                        }
                        index++;
                    }
                }
            }
            index = 0;

            foreach (Control p in sportsPanel.Controls)
            {
                foreach (Control i in p.Controls)
                {
                    if (index + 1 < sportsevents.Count)
                    {
                        if (i is PictureBox)
                        {
                            PictureBox pic = (PictureBox)i;
                            pic.Load(sportsevents.ElementAt(index).GetImage());
                        }
                        if (i is Label)
                        {
                            Label lb = (Label)i;
                            lb.Text = sportsevents.ElementAt(index).GetTitle();
                        }
                        index++;
                    }
                }
            }
            index = 0;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
