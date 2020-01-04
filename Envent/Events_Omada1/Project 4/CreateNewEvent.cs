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
       
        public CreateNewEvent()
        {
            InitializeComponent();
          
        }

        public int Id;
      

        private void CreateNewEvent_Load(object sender, EventArgs e)
        {
            Addplay.Enabled = false;
            savebtn.Enabled = false;
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
        Boolean deiktislathwn;
        private Boolean checkall()
        {
            //den exei ginei elegxos gia eikona
            deiktislathwn = true;
            if (titlos.Text == "")
                deiktislathwn = false;
            else if (perigrafi.Text == "")
                deiktislathwn = false;
            else if (durationhour.Value == 0 || durationmin.Value == 0)
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
         
        private void createEvent_Click(object sender, EventArgs e)
        {

            EventManager em = (EventManager)uem;
            em.CreateEvent(titlos.Text, katigoriacomboboxselect(), perigrafi.Text, selectedduration());
            //edw apotelesma pou an gurizei id event

            //enable ta textbox 
            titlos.Enabled = true;
            katigoria.Enabled = true;
            durationhour.Enabled = true;
            durationmin.Enabled = true;
            uploadImage.Enabled = true;
            createEvent.Enabled = true;


            
        }

        private void createplaypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addplay_Click(object sender, EventArgs e)
        {
            int normalticket = Convert.ToInt32(kanonikoticket.Value);
            int reducedticket = Convert.ToInt32(meiomenoticket.Value);
            //dokimastiko id play
            int play_id=0;
            Ticket tic = new Ticket();
            tic.CreateTicket("normal", normalticket, play_id);
            tic.CreateTicket("reduced", reducedticket, play_id);




            ///entoles gia na emfanizei to play poy egine
            String date= dateofPlay.Value.ToString("yyyy-MM-dd");
            String time = timepicker.Value.ToString();
            String kan = kanonikoticket.Value.ToString();
            String meiom = meiomenoticket.Value.ToString();
            ListViewItem item = new ListViewItem(date);
            item.SubItems.Add(time);
            item.SubItems.Add(topothesia.Text);
            item.SubItems.Add(kan);
            item.SubItems.Add(meiom);

        }

        private void kanonikoticket_ValueChanged(object sender, EventArgs e)
        {

        }

        Boolean tit = false;
        Boolean katig = false;
        Boolean per = false;
        Boolean dur = false;

        private void circularPicture5_Click(object sender, EventArgs e)
        { 
            createEvent.Visible = false;
            savechanges.Visible = true;
            titlos.Enabled = false;
            tit = true;
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            createEvent.Visible = false;
            savechanges.Visible = true;
            katigoria.Enabled = false;
            katig = true;
        }

        private void circularPicture4_Click(object sender, EventArgs e)
        {
            createEvent.Visible = false;
            savechanges.Visible = true;
            perigrafi.Enabled = false;
            per = true;
        }

        private void circularPicture2_Click(object sender, EventArgs e)
        {
            createEvent.Visible = false;
            savechanges.Visible = true;
            durationhour.Enabled = false;
            durationmin.Enabled = false;
            dur = true;
        }

        private void circularPicture3_Click(object sender, EventArgs e)
        {

            createEvent.Visible = false;
            savechanges.Visible = true;
            uploadImage.Enabled = false;

            
        }

        private void savechanges_Click(object sender, EventArgs e)
        {
            EventManager em = (EventManager)uem;
            
            if (tit = true)
            {
                em.UpdateEventTitle(1, titlos.Text);
            }
            else if (katig = true)
            {
                em.UpdateEventCategory(1, katigoriacomboboxselect());
            }
            else if (per = true)
            {
                em.UpdateEventDescription(1, perigrafi.Text);

            }
            else if (dur = true) {
                em.UpdateEventDuration(1, selectedduration());
            }
            tit = false;
            katig = false;
            per = false;
            dur = false;
            savechanges.Visible = false;
            createEvent.Visible = true;
            createEvent.Enabled = false;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
