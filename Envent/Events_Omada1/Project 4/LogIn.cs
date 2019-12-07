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

namespace Project_4
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void EmailLog_Click(object sender, EventArgs e)
        {
            EmailLog.ForeColor = Color.Black;
            if (EmailLog.Text == "Email" || EmailLog.Text == "Συμπλήρωσε Email")
            {

                EmailLog.Text = "";
                EmailLog.ForeColor = Color.Black;

            }
        }

        private void EmailLog_Leave(object sender, EventArgs e)
        {
            if (EmailLog.Text == "")
            {
                EmailLog.Text = "Email";
                EmailLog.ForeColor = Color.Gray;


            }
        }

        private void PasswordLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLog_Click(object sender, EventArgs e)
        {
            PasswordLog.ForeColor = Color.Black;
            if (PasswordLog.Text == "Κωδικός" || PasswordLog.Text == "Συμπλήρωσε Kωδικό")
            {

                PasswordLog.Text = "";
                PasswordLog.ForeColor = Color.Black;
                PasswordLog.PasswordChar = '*';
            }
        }

        private void PasswordLog_Leave(object sender, EventArgs e)
        {
            if (PasswordLog.Text == "")
            {
                PasswordLog.Text = "Κωδικός";
                PasswordLog.ForeColor = Color.Gray;
                PasswordLog.PasswordChar = '\0';

            }
        }

        private Boolean AllCheck()
        {

            /* Boolean deiktislathwn = false;
             if (EmailLog.Text == "" || EmailLog.Text == "Email")
             {
                 EmailLog.ForeColor = Color.Red;
                 EmailLog.Text = "Συμπλήρωσε Email";
                 deiktislathwn = true;


             }
             if (PasswordLog.Text == "" || PasswordLog.Text == "Κωδικός")
             {

                 PasswordLog.ForeColor = Color.Red;
                 PasswordLog.Text = "Συμπλήρωσε Kωδικό";
                 deiktislathwn = true;


             }

             return deiktislathwn;
             */

            enventDbDataSetTableAdapters.userTableAdapter login = new enventDbDataSetTableAdapters.userTableAdapter();
            login.login('test');

        }


        private void Syndesi_Click(object sender, EventArgs e)
        {
            if (AllCheck() == false)
            {
                //kane eisodo


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInpanel.Controls.Clear();
            ForgetPassword su = new ForgetPassword();
            LogInpanel.Controls.Add(su);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
