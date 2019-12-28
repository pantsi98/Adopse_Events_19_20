using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class EventFullDescription : UserControl
    {
        public EventFullDescription()
        {
            InitializeComponent();
        }

        String description;
        String title;
        int duration;


        private void EventFullDescription_Load(object sender, EventArgs e)
        {
            try
            {
                //paradeigma fortiseis tou event me id =12
                User_Classes.Event event1 = new User_Classes.Event(12);
                description = event1.GetDescription();
                title = event1.GetTitle();
                duration=event1.GetDuration();




            }
            catch (User_Classes.Exceptions.EventException msg)
            {
                Cursor.Current = Cursors.Default;
                label10.Text = msg.ToString();

            }



            //Anathesi timwn sta katallila labels
            String dur = duration.ToString();

            durationlabel.Text = dur;
            titleLabel.Text = title;
            perigrafilabel.Text = description;

        }


        

    }

  
}
