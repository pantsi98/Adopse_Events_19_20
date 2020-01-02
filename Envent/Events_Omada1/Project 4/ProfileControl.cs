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

        //On load παίρνει τις τιμές απο το dataset και τις βάζει στα πεδία και τις τοπικές μεταβλητές .
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
            if (String.Equals(usernamTextBox.Text, usrname) == false)
            {
                datachange = true;
                if (ValidationCheck.CheckUserName(usernamTextBox.Text))
                {

                    usernameExist.Visible = true;
                    button1.Enabled = false;
                }
                else
                {

                    usernameExist.Visible = false;
                    button1.Enabled = true;
                }
            }
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

        

        private void circularPicture7_Click_1(object sender, EventArgs e)
        {
            if (emailTextBox.Enabled) { emailTextBox.Enabled = false; }
            else
            {
                emailTextBox.Enabled = true;
            }
        }

        
        //Save button click that makes the updates
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(datachange == true)
            {
                    NormalUser nu = (NormalUser)x;
                    Profile up = nu.GetProfile();                
                    up.UpdateUserName(Id, usernamTextBox.Text);                   
                    up.UpdateAddress(Id, adressTextBox.Text);
                    up.UpdateEmail(Id, emailTextBox.Text);
                    up.UpdateFirstName(Id, onomaTextBox.Text);
                    up.UpdateLastName(Id, lastnameTextBox.Text);
                    MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν.");
                    string pass = nu.GetPass();
                    InstanceOfUser.LogOut();
                    InstanceOfUser.CreateCustomerUser(usrname, pass);
                
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

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            emailTextBox.Enabled = false;
            if (String.Equals(emailTextBox.Text, email) == false)
            {
                datachange = true;
                if (ValidationCheck.CheckEmail(emailTextBox.Text))
                {

                    emailExist.Visible = true;
                    button1.Enabled = false;
                }
                else
                {

                    emailExist.Visible = false;
                    button1.Enabled = true;
                }
            }
        }

        
    }
}
