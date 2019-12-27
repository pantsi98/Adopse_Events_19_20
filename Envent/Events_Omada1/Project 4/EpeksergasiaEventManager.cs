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
    public partial class EpeksergasiaEventManager : UserControl
    {
        public EpeksergasiaEventManager()
        {
            InitializeComponent();
        } 
       
        private void EpeksergasiaEventManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            if (onomaTextBox.Enabled) { onomaTextBox.Enabled = false; }
            else
            {
                onomaTextBox.Enabled = true;
            }
        }

        private void circularPicture7_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Enabled) { passwordTextBox.Enabled = false; }
            else
            {
                passwordTextBox.Enabled = true;

            }
        }

        private void circularPicture6_Click(object sender, EventArgs e)
        {
            if (adressTextBox.Enabled) { adressTextBox.Enabled = false; }
            else
            {
                adressTextBox.Enabled = true;
            }
        }

        private void circularPicture8_Click(object sender, EventArgs e)
        {
            if (lastnameTextBox.Enabled) { lastnameTextBox.Enabled = false; }
            else
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
        Boolean dodpickerd=false;
        private void circularPicture9_Click(object sender, EventArgs e)
        {
            if (dobPicker.Enabled) {
                dobPicker.Enabled = false;
                dodpickerd = true;

            }
            else
            {
                dobPicker.Enabled = true;
            }
        }

        private void dobPicker_Leave(object sender, EventArgs e)
        {
            dobPicker.Enabled = false;
        }

        private void circularPicture10_Click(object sender, EventArgs e)
        {
            if (IBANtextbox.Enabled) { IBANtextbox.Enabled = false; }
            else
            {
                IBANtextbox.Enabled = true;
            }

        }
        //dokimastikomanagerprofil
        ManagerProfile mp = new ManagerProfile(7, false);
        private void Save_Click(object sender, EventArgs e)
        {
            if (usernamTextBox.Text != "")
            {
                mp.UpdateUserName(7, usernamTextBox.Text);

            }
            else if (onomaTextBox.Text != "") {
                mp.UpdateFirstName(7, onomaTextBox.Text);

            }
            else if (lastnameTextBox.Text != "")
            {
                mp.UpdateLastName(7, lastnameTextBox.Text);

            }
            else if (adressTextBox.Text != "")
            {
                mp.UpdateAddress(7, adressTextBox.Text);

            }
            else if (passwordTextBox.Text != "")
            {
                mp.UpdatePassword(7, passwordTextBox.Text);

            }
            else if (IBANtextbox.Text != "")
            {
               // mp.updateIban(7, IBANtextbox.Text);

            }
            else if (dodpickerd=true)
            {


                // mp.updateDateofbirth(7,dobPicker.Value());


            }


        }

        private void IBANtextbox_Leave(object sender, EventArgs e)
        {
            IBANtextbox.Enabled = true;
        }
    }
}
