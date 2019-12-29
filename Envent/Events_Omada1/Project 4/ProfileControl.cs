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
    public partial class ProfileControl : UserControl
    {
        User x = InstanceOfUser.GetUser();
        public bool datachange = false;
        public int Id;
        public string onoma;
        public string lastname;
        public string email;
        public string adress;
        public string usrname;
        public DateTime dob;
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
            if (x is NormalUser)
            {
                NormalUser nu = (NormalUser)x;
                Id = nu.GetUserID();
                usrname = usernamTextBox.Text = nu.GetUserName();
                onoma = onomaTextBox.Text = nu.GetProfile().GetFirstName();
                lastname = lastnameTextBox.Text = nu.GetProfile().GetLastName();
                email = emailTextBox.Text = nu.GetProfile().GetEmail();
                dob = dobPicker.Value = nu.GetProfile().GetDob();
                adress = adressTextBox.Text = nu.GetProfile().GetAddress();
            }
        }

        private void cCircularButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circularPicture4_Click(object sender, EventArgs e)
        {
            if (usernamTextBox.Enabled)
            {
                usernamTextBox.Enabled = false;
            }
            else usernamTextBox.Enabled = true;
        }

        private void circularPicture5_Click(object sender, EventArgs e)
        {
            if (onomaTextBox.Enabled) { onomaTextBox.Enabled = false; } else
            {
                onomaTextBox.Enabled = true;
            }
        }

        

        private void circularPicture6_Click(object sender, EventArgs e)
        {
            if (adressTextBox.Enabled) { adressTextBox.Enabled = false; } else
            {
                adressTextBox.Enabled = true;
            }
        }

        private void circularPicture8_Click(object sender, EventArgs e)
        {
            if (lastnameTextBox.Enabled) { lastnameTextBox.Enabled = false; } else
            {
                lastnameTextBox.Enabled = true;
            }
        }

        private void usernamTextBox_Leave(object sender, EventArgs e)
        {
            usernamTextBox.Enabled = false;
            
        }

        private void onomaTextBox_Leave(object sender, EventArgs e)
        {
            onomaTextBox.Enabled = false;
            if (String.Equals(onomaTextBox.Text, onoma) == false)
            {
                datachange = true;
            }
        }

        private void adressTextBox_Leave(object sender, EventArgs e)
        {
            adressTextBox.Enabled = false;
            if (String.Equals(adressTextBox.Text, adress) == false)
            {
                datachange = true;
            }
        }

        

        private void lastnameTextBox_Leave(object sender, EventArgs e)
        {
            lastnameTextBox.Enabled = false;
            if (String.Equals(lastnameTextBox.Text, lastname) == false)
            {
                datachange = true;
            }
        }

        private void circularPicture9_Click(object sender, EventArgs e)
        {
            if (dobPicker.Enabled) { dobPicker.Enabled = false; }
            else
            {
                dobPicker.Enabled = true;
            }
        }

        private void dobPicker_Leave(object sender, EventArgs e)
        {
            dobPicker.Enabled = false;
            if (dobPicker.Value != dob)
            {
                datachange = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void circularPicture7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(datachange == false)
            {
                NormalUser nu =(NormalUser)x;
                Profile up =nu.GetProfile();
                up.UpdateAddress(Id, adressTextBox.Text);
                up.UpdateEmail(Id, emailTextBox.Text);
                up.UpdateFirstName(Id, onomaTextBox.Text);
                up.UpdateLastName(Id, lastnameTextBox.Text);
                up.UpdateUserName(Id, usernamTextBox.Text);
                MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν.");
            }
            else
            {
                MessageBox.Show("Δεν έγινε κάποια αλλαγή για να αλλάξουν τα δεδομένα");
            }
        }
    }
}
