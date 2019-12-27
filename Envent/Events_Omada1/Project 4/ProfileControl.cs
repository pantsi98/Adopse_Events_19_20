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
using Project_4.App_Code;

namespace Project_4
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            User x = InstanceOfUser.GetUser();
            if (x is NormalUser)
            {
                NormalUser nu = (NormalUser)x;
                onomaTextBox.Text = nu.GetProfile().GetFirstName();
                lastnameTextBox.Text = nu.GetProfile().GetLastName();
                emailTextBox.Text = nu.GetProfile().GetEmail();
                genderTextBox.Text = nu.GetProfile().GetGender();
                dobPicker.Value = nu.GetProfile().GetDob();
                adressTextBox.Text = nu.GetProfile().GetAddress();
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

        private void circularPicture7_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Enabled) { passwordTextBox.Enabled = false; } else
            {
                passwordTextBox.Enabled = true;

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
        }

        private void adressTextBox_Leave(object sender, EventArgs e)
        {
            adressTextBox.Enabled = false;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = false;
        }

        private void lastnameTextBox_Leave(object sender, EventArgs e)
        {
            lastnameTextBox.Enabled = false;
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
        }
    }
}
