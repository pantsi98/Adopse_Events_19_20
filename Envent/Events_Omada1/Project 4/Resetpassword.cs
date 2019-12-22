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
    public partial class Resetpassword : UserControl
    {
        public Resetpassword()
        {
            InitializeComponent();
        }

        private void Resetpassword_Load(object sender, EventArgs e)
        {
            ChangePassBtn.Enabled = false;

        }

        private void resetparcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetparcode_Click(object sender, EventArgs e)
        {
            if (resetparcode.Text == "Κωδικός επαναφοράς") {
                resetparcode.Text = "";
                resetparcode.ForeColor = Color.Black;
            }
        }

        private void NewPassword_Click(object sender, EventArgs e)
        {
            if (NewPassword.Text == "Νέος κωδικός ") {
                NewPassword.Text = "";
                NewPassword.ForeColor = Color.Black;
                NewPassword.PasswordChar = '*';

            }
        }

        private void resetparcode_Leave(object sender, EventArgs e)
        {
            if (resetparcode.Text == "") {
                resetparcode.ForeColor = Color.Red;
                resetparcode.Text = "Παρακαλώ συμπληρώστε κωδικό επαναφοράς";

            }
        }
        Boolean checkpassIsValid;
        private void NewPassword_Leave(object sender, EventArgs e)
        {
            checkpassIsValid = true;
            passwordlabel.Visible = false;
            if (NewPassword.Text == "")
            {
                NewPassword.ForeColor = Color.Red;
                NewPassword.Text = "Παρακαλώ συμπλήρωστε κωδικό";
                NewPassword.PasswordChar = '\0';

            }
            else
            {
                if (!App_Code.StaticMethods.ValidationCheck.PasswordIsValid(NewPassword.Text))
                {
                    passwordlabel.Visible = true;
                    passwordlabel.Text = "Ο κωδικός πρέπει να περιέχει τουλάχιστον 8 χαρακτήρες , κεφαλαιο και μικρό γράμμα και νούμερο.";
                    checkpassIsValid = false;
                }
            }
        }
            Boolean deiktislathwn;
            private Boolean AllCheck()
            {
                deiktislathwn = true;

                if (resetparcode.Text == "Κωδικός επαναφοράς" || resetparcode.Text == "" || resetparcode.Text == "Παρακαλώ συμπληρώστε κωδικό επαναφοράς")
                {
                    deiktislathwn = false;
                }
                else if (NewPassword.Text == "Κωδικός επαναφοράς" || NewPassword.Text == "" || NewPassword.Text == "Παρακαλώ συμπληρώστε κωδικό")
                {
                    deiktislathwn = false;
                }
                else if (checkpassIsValid == false)
                {
                    deiktislathwn = false;
                 }
            return deiktislathwn;

            }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (!AllCheck())
            {
                ChangePassBtn.Enabled = false;
            }
            else
            {
                ChangePassBtn.Enabled = true;
            }


        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            //kane allagi kwdikou me vasi

            try
            {


                //επιτυχης αλλαγή
                Cursor.Current = Cursors.WaitCursor;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Η αλλαγη κωδικού ήταν επιτυχής !");
                Controls.Clear();


            }
            catch { }


        }

        Boolean isvisible=false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isvisible = false)
            {
                visiblepas.Image = global::Project_4.Properties.Resources.hide;
                NewPassword.PasswordChar = '\0';
                isvisible = true;
            }
            else {
                visiblepas.Image = global::Project_4.Properties.Resources.eye;
                NewPassword.PasswordChar = '*';
                isvisible = false;
            }


        }
    } 
}
