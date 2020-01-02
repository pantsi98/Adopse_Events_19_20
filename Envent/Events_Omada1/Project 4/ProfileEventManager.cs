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
    public partial class ProfileEventManager : UserControl
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
        public ProfileEventManager()
        {
            InitializeComponent();
        }

        private void EmanPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createnewevent_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CreateNewEvent su = new CreateNewEvent();
            panel1.Controls.Add(su);

        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void ProfileEventManager_Load(object sender, EventArgs e)
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

        private void circularPicture9_Click(object sender, EventArgs e)
        {
            if (dobPicker.Enabled) { dobPicker.Enabled = false; }
            else
            {
                dobPicker.Enabled = true;
            }
        }

        private void circularPicture7_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Enabled) { emailTextBox.Enabled = false; }
            else
            {
                emailTextBox.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datachange == true)
            {
                EventManager nu = (EventManager)x;
                Profile up = nu.GetProfile();
                up.UpdateAddress(Id, adressTextBox.Text);
                up.UpdateEmail(Id, emailTextBox.Text);
                up.UpdateFirstName(Id, onomaTextBox.Text);
                up.UpdateLastName(Id, lastnameTextBox.Text);
                up.UpdateUserName(Id, usernamTextBox.Text);
                MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν.");
                string pass = nu.GetPass();
                InstanceOfUser.LogOut();
                InstanceOfUser.CreateEventManager(usrname, pass);
            }
            else
            {
                MessageBox.Show("Δεν έγινε κάποια αλλαγή για να αλλάξουν τα δεδομένα");
            }
        }

        private void passChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            ResetPassword su = new ResetPassword();
            panel1.Controls.Add(su);
        }
    }
}
