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
    public partial class ForgetPassword : UserControl
    {
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
                try
                {
                    //entoles gia syndesi me vasi



                    //entoles gia emfanisi tou epomenou user control
                    ForgotPaspanel.Controls.Clear();
                    Resetpassword ru = new Resetpassword();
                    ForgotPaspanel.Controls.Add(ru);

                }catch{

                    messagelabel.Visible = true;
                    EmailForgot.Text = "Email";
                    EmailForgot.ForeColor = Color.DimGray;

                }



            }



        }
    }
    }
    

