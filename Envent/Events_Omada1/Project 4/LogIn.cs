using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;

namespace Project_4
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }
   
        private void LogIn_Load_1(object sender, EventArgs e)
        {
            Syndesi.Enabled = false;
           
            UsernameLog.Text = "Username";
           
            PasswordLog.Text = "Κωδικός";

        }

        private void UsernameLog_Click(object sender, EventArgs e)
        {
            UsernameLog.ForeColor = Color.Black;
            if (UsernameLog.Text == "Username" || UsernameLog.Text == "Συμπληρώστε Username")
            {

                UsernameLog.Text = "";
                UsernameLog.ForeColor = Color.Black;

            }
 }
        private void PasswordLog_Click(object sender, EventArgs e)
        {
            PasswordLog.ForeColor = Color.Black;
            if (PasswordLog.Text == "Κωδικός" || PasswordLog.Text == "Συμπληρώστε Kωδικό")
            {

                PasswordLog.Text = "";
                PasswordLog.ForeColor = Color.Black;
                PasswordLog.PasswordChar = '*';
            }
        }

        private void UsernameLog_Leave(object sender, EventArgs e)
        {
            if (UsernameLog.Text == "")
            {
                UsernameLog.Text = "Συμπληρώστε Username";
                UsernameLog.ForeColor = Color.Red;
                UsernameLog.PasswordChar = '\0';

            }

        }
        private void PasswordLog_Leave(object sender, EventArgs e)
        {
            if (PasswordLog.Text == "" )
            {

                PasswordLog.ForeColor = Color.Red;
                PasswordLog.Text = "Συμπληρώστε Kωδικό";
                PasswordLog.PasswordChar = '\0';

            }
        }

        private Boolean AllCheck()
        {

            Boolean deiktislathwn = true;
            if (UsernameLog.Text == "" || UsernameLog.Text == "Username" || UsernameLog.Text == "Συμπληρώστε Username")
            {
                deiktislathwn = false;
            }
            if (PasswordLog.Text == "" || PasswordLog.Text == "Κωδικός" || PasswordLog.Text== "Συμπληρώστε Kωδικό")
            { 
                deiktislathwn = false;
            }

            return deiktislathwn;
        }


        private void Syndesi_Click(object sender, EventArgs e)
        {
            loginfail.Visible = false;
            if (AllCheck() == true)
            {


                //kane eisodo
                User_Classes.Visitor vis = new User_Classes.Visitor();
                String username = UsernameLog.Text;
                String password = PasswordLog.Text;

                try
                {
                    //try gia na dei ean einai normaluser
                    Cursor.Current = Cursors.WaitCursor;
                    vis.LogInAsNormalUser(username, password);
                    NormalUser nu = (NormalUser)InstanceOfUser.GetUser();
                    MessageBox.Show(nu.GetUserID().ToString());
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show("Είσοδος στον λογαριασμό σας!", "OK", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        Control parent = this.Parent;
                        while (parent.Name != "Form1")
                        {
                            Debug.WriteLine(parent.Name);
                            parent = parent.Parent;
                        }

                        foreach (Control c in parent.Controls)
                        {
                            if (c.Name == "homepagePanel")
                            {
                                parent = c;
                            }
                        }

                        switch (parent.Controls["button8"].Text) 
                        {
                            case "LOGIN":
                                parent.Controls["button8"].Text = "LOGOUT";
                                parent.Controls["button7"].Visible = false;
                                parent.Controls["cCircularbutton1"].Visible = true;
                                break;
                        }
                        
                        Controls.Clear();
                        Controls.Add(new HomeMain());
                    }
                }
                catch (User_Classes.Exceptions.FailLogInAsNormalUser msg)
                {//ean den einainormaluser ,try ean einai eventmanager
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        vis.LogInAsEventManager(username, password);
                        Cursor.Current = Cursors.Default;
                        if (MessageBox.Show("Είσοδος στον λογαριασμό σας!", "OK", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            Control parent = this.Parent;
                            while (parent.Name != "Form1")
                            {
                                Debug.WriteLine(parent.Name);
                                parent = parent.Parent;
                            }

                            foreach (Control c in parent.Controls)
                            {
                                if (c.Name == "homepagePanel")
                                {
                                    parent = c;
                                }
                            }
                            switch (parent.Controls["button8"].Text)
                            {
                                case "LOGIN":
                                    parent.Controls["button8"].Text = "LOGOUT";
                                    parent.Controls["button7"].Visible = false;
                                    parent.Controls["cCircularbutton1"].Visible = true;
                                    break;
                            }

                            Controls.Clear();
                            Controls.Add(new HomeMain());
                        }
                    }
                    catch (User_Classes.Exceptions.FailLoginAsEventManager msg1)
                    {//ean den einai emfanizei minma lathous 
                        Cursor.Current = Cursors.Default;
                        messagelabel.Text = msg1.ToString();
                        loginfail.Visible = true;
                        
                        UsernameLog.ForeColor = System.Drawing.Color.Gray;
                        UsernameLog.Text = "Username";
                        PasswordLog.ForeColor = System.Drawing.Color.Gray;
                        PasswordLog.Text = "Κωδικός";
                    }
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInpanel.Controls.Clear();
            ForgetPassword su = new ForgetPassword();
            LogInpanel.Controls.Add(su);


        }

        private void LogInpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInpanel_MouseHover(object sender, EventArgs e)
        {
         
                if (!AllCheck())
                {
                    Syndesi.Enabled = false;
                }
                else
                {
                    Syndesi.Enabled = true;
                }
            }

        private void UsernameLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            PasswordLog.ForeColor = Color.Black;
            if (PasswordLog.Text == "Κωδικός" || PasswordLog.Text == "Συμπληρώστε Kωδικό")
            {

                PasswordLog.Text = "";
                PasswordLog.ForeColor = Color.Black;
                PasswordLog.PasswordChar = '*';
            }
        }
    }
    }

