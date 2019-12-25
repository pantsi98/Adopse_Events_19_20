using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using Project_4.App_Code.StaticMethods;
using Project_4.User_Classes;
using Project_4.App_Code;


namespace Project_4
{
    public partial class ForgetPassword : UserControl
    {
        //dimiorgia tou forgot password - panagiotis
        string randomCode;
        string theEmail;
        public static string to;
        

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            private void EmailForgot_Click(object sender, EventArgs e)
            {
                EmailForgot.ForeColor = Color.Black;
                if (EmailForgot.Text == "Email" || EmailForgot.Text == "Συμπλήρωσε Email")
                {

                    EmailForgot.Text = "";
                    EmailForgot.ForeColor = Color.Black;
                
                }
            }


        private void EmailForgot_TextChanged(object sender, EventArgs e)
        {

        }

        
            private void EmailForgot_Leave(object sender, EventArgs e)
            {
                if (EmailForgot.Text == "")
                {
                EmailForgot.Text = "Email";
                EmailForgot.ForeColor = Color.Gray;


                }
            }

        private Boolean Check()
        {

            Boolean deiktislathwn = false;
            if (EmailForgot.Text == "" || EmailForgot.Text == "Email")
            {
                EmailForgot.ForeColor = Color.Red;
                EmailForgot.Text = "Συμπλήρωσε Email";
                deiktislathwn = true;
            }


                return deiktislathwn;
        }


        private Boolean emailExists()
        {
            bool result;
            //elegxoume an yparxei to email sti vasi
            enventDataSetTableAdapters.userTableAdapter kati = new enventDataSetTableAdapters.userTableAdapter();
            int counter = Convert.ToInt32(kati.checkEmail(EmailForgot.Text));
            if (counter > 0)
                result = true;
            else
                result = false;
            return result;
        }


        //set k get
        private void setEmail(string x)
        {
            string email = x;
        }
        public string getEmail()
        {
            return theEmail ;
        }

            private void button1_Click(object sender, EventArgs e){
            //Dimiourgia antikeimenou gia na pame to email se alli klasi
            theEmail = EmailForgot.Text;


            User x = InstanceOfUser.GetUser();

            if(x is Visitor)
            {
                Visitor vis = (Visitor)x;
                enventDataSetTableAdapters.userTableAdapter env = new enventDataSetTableAdapters.userTableAdapter();
                
                string username = env.returnUsernamePassword(theEmail).ToList().ElementAt(0).username;
                string password = env.returnUsernamePassword(theEmail).ToList().ElementAt(0).password;

                NormalUser nu = (NormalUser)vis.LogInAsNormalUser(username, password);

                


            }






            if (emailExists())
            {
               //Dimiourgia Random Verification Code
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();

                //Apostoli Email
                MailMessage mm = new MailMessage("adopsetest@gmail.com", EmailForgot.Text.Trim());
                mm.Subject = "Κωδικός Επαναφοράς";
                mm.Body = string.Format("Ο κωδικός επαναφοράς είναι: " + randomCode);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = "adopsetest@gmail.com";
                NetworkCred.Password = "adopsetest2019";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                labelSend.ForeColor = Color.Green;
                labelSend.Text = "Ο κωδικός επαναφοράς εστάλη επιτυχώς!";
            }
            else
            {
                labelSend.ForeColor = Color.Red;
                labelSend.Text = "Το e-mail δεν βρέθηκε";
            }
        }

        private void ver_button_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerCode.Text).ToString())
            {
                ForgotPaspanel.Controls.Clear();
                ResetPassword rp = new ResetPassword();
                ForgotPaspanel.Controls.Add(rp);
                rp.Show();
            }
            else
            {
                MessageBox.Show("Λάθος κωδικός");
            }
        }
    }
    }
    

