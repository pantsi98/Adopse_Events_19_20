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

namespace Project_4
{
    public partial class EventFullDescription : UserControl
    {
        public EventFullDescription()
        {
            InitializeComponent();
        }

        public EventFullDescription(int id)
        {
            InitializeComponent();
            PrepareElements(id);
        }

        String description;
        String title;
        int duration;


        private void PrepareElements(int id)
        {
            User_Classes.Event event_kati = new User_Classes.Event(id);
            this.eventTitle.Text = event_kati.GetTitle();
            this.imerominia.Text = event_kati.GetCreatedAt().Date.ToString();
            this.perigrafilabel.Text = event_kati.GetDescription().ToString();
            


           
        }

        private void EventFullDesbcriptionPrepare(string ttl, string desc, int dur)
        {
          //  this.titleLabel.Text = ttl;
           // this.perigrafilabel.Text = desc;
            this.durationlabel.Text = dur.ToString();
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
            String dur = duration.ToString();

           // durationlabel.Text = dur;
            //eventTitle.Text = title;
            //perigrafilabel.Text = description;

        }


        

    }

  
}
