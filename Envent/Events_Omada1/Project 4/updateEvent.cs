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
using Project_4.User_Classes;

namespace Project_4
{
    public partial class updateEvent : UserControl
    {
        User uem = InstanceOfUser.GetUser();
      
        public updateEvent()
        {
            InitializeComponent();
            //enable ta textbox 
            titlos.Enabled = true;
            katigoria.Enabled = true;
            durationhour.Enabled = true;
            durationmin.Enabled = true;
            statuscombobox.Enabled = true;
            savechanges.Enabled = true;
        }

        Boolean tit = false;
        Boolean katig = false;
        Boolean per = false;
        Boolean dur = false;
        Boolean status = false;

        private void circularPicture5_Click(object sender, EventArgs e)
        {
            titlos.Enabled = false;
            tit = true;
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            katigoria.Enabled = false;
            katig = true;
        }

        private void circularPicture4_Click(object sender, EventArgs e)
        {
            perigrafi.Enabled = false;
            per = true;
        }

        private void circularPicture2_Click(object sender, EventArgs e)
        {
            durationhour.Enabled = false;
            durationmin.Enabled = false;
            dur = true;
        }

        private void circularPicture3_Click(object sender, EventArgs e)
        {
            statuscombobox.Enabled = false;
            status = true;

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
        private void savechanges_Click(object sender, EventArgs e)
        {
            EventManager em = (EventManager)uem;
            if (tit = true || titlos.Text != "")
            {
                em.UpdateEventTitle(1, titlos.Text);
            }
            if (katig = true || katigoria.Text != "")
            {
                em.UpdateEventCategory(1, katigoriacomboboxselect());
            }
            if (per = true || perigrafi.Text != "")
            {
                em.UpdateEventDescription(1, perigrafi.Text);

            }
            if (dur = true || !(durationhour.Value == 0 || durationmin.Value == 0))
            {
                em.UpdateEventDuration(1, selectedduration());
            }
            if (status = true || statuscombobox.Text!="")
            {
               if(statuscombobox.SelectedValue == "Ενεργό")
                {
                    em.ChangeEventStatus(1, true);

                }
                else {
                    em.ChangeEventStatus(1, false);
                }


            }
            tit = false;
            katig = false;
            per = false;
            dur = false;
            status = false;
            //enable ta textbox 
            titlos.Enabled = true;
            katigoria.Enabled = true;
            durationhour.Enabled = true;
            durationmin.Enabled = true;
            statuscombobox.Enabled = true;
            savechanges.Enabled = true;
        }
    }
}
