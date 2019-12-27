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

namespace Project_4
{
    public partial class CreateNewEvent : UserControl
    {
        public CreateNewEvent()
        {
            InitializeComponent();
        }

        private void CreateNewEvent_Load(object sender, EventArgs e)
        {
            Addplay.Enabled = false;
            Savebtn.Enabled = false;
           
        }

        private void BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);

            }
        }

       
        Boolean deiktislathwn;
        private Boolean checkall() {
            //den exei ginei elegxos gia eikona
            deiktislathwn=true;
            if (titlos.Text == "")
                deiktislathwn = false;
            else if(perigrafi.Text=="")
                deiktislathwn = false;
            else if (durationhour.Value==0 || durationmin.Value==0)
                deiktislathwn = false;
            else if (topothesia.Text == "")
                deiktislathwn = false;
            else if (kanonikoticket.Value==0 || meiomenoticket.Value==0)
                deiktislathwn = false;
            else if (timehour.Value==0 || Timemin.Value==0)
                deiktislathwn = false;
            
        
            return deiktislathwn;
        }

        private void CreateNewEvent_MouseHover(object sender, EventArgs e)
        {
            if (!checkall())
            {
                Addplay.Enabled = false;
            }
            else
            {
                Addplay.Enabled = true;
            }

            
        }

        


        int kat;
        //methodos gia na dinei to swsto id stin katigoria
       private int katigoriacomboboxselect() {
           
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
           int min= Convert.ToInt32(Math.Round(durationmin.Value));
           return  hour * 60 + min;

        }

        //dokimastikos eventmanager
      //  EventManager em = new EventManager("user1", "1234");
        

        private void createEvent_Click(object sender, EventArgs e)
        {

          //  em.CreateEvent(titlos.Text, katigoriacomboboxselect(), perigrafi.Text, selectedduration());
          //  createplaypanel.Visible = true;

        }
        private void AddPlay_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
