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

namespace Project_4
{
    public partial class ForgetPassword : UserControl
    {
        //dimiorgia tou forgot password - panagiotis
        string randomCode;
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

            private void button1_Click(object sender, EventArgs e)

        {
            if (Check() == false)
            {
                //steile meil
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (EmailForgot.Text).ToString();
                from = "adopsetest@gmail.com";
                pass = "adopsetest2019";
                messageBody = "your reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Επαναφορά Κωδικού";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Ο κωδικός εστάλη επιτυχώς" + randomCode);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }



        }

        private void ver_button_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerCode.Text).ToString())
            {
                to = EmailForgot.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Λάθος κωδικός");
            }
        }
    }
    }
    

