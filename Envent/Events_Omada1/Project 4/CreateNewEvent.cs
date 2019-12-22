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
            preViewbtn.Enabled = false;
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

        private void AddPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
