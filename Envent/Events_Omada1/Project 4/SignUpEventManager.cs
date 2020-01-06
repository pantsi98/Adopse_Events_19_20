
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
    public partial class SignUpEventManager : UserControl
    {
        public SignUpEventManager()
        {
            InitializeComponent();
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {
            Register.Enabled = false;
            maleRadioButton.Checked = true;

        }


        private void Onoma_MouseClick(object sender, EventArgs e)
        {

            Onoma.ForeColor = Color.Black;
            if (Onoma.Text == "Όνομα" || Onoma.Text == "Παρακαλω συμπλήρωστε όνομα")
            {
                Onoma.Text = "";
                Onoma.ForeColor = Color.Black;
            }
        }

        private void Epitheto_MouseClick(object sender, EventArgs e)
        {
            Epitheto.ForeColor = Color.Black;
            if (Epitheto.Text == "Επώνυμο" || Epitheto.Text == "Παρακαλώ συμπλήρωστε επώνυμο")
            {

                Epitheto.Text = "";
                Epitheto.ForeColor = Color.Black;

            }

        }

        private void IBAN_MouseClick(object sender, MouseEventArgs e)
        {
            IBAN.ForeColor = Color.Black;
            if (IBAN.Text == "IBAN" || IBAN.Text == "Παρακαλώ συμπλήρωστε IBAN")
            {

                IBAN.Text = "";
                IBAN.ForeColor = Color.Black;

            }



        }
        private void username1_MouseClick(object sender, EventArgs e)
        {
            username1.ForeColor = Color.Black;
            if (username1.Text == "Username" || username1.Text == "Παρακαλώ συμπλήρωστε ψευδόνυμο")
            {

                username1.Text = "";
                username1.ForeColor = Color.Black;

            }
        }

        private void Email1_MouseClick(object sender, EventArgs e)
        {
            Email1.ForeColor = Color.Black;
            if (Email1.Text == "Email" || Email1.Text == "Παρακαλω συμπλήρωστε Email")
            {

                Email1.Text = "";
                Email1.ForeColor = Color.Black;

            }
        }
        private void address_MouseClick(object sender, EventArgs e)
        {
            address.ForeColor = Color.Black;
            if (address.Text == "Περιοχή" || address.Text == "Παρακαλώ συμπληρώστε διέυθυνση")
            {

                address.Text = "";
                address.ForeColor = Color.Black;

            }
        }
        private void Kodikos1_MouseClick(object sender, EventArgs e)
        {
            Kodikos1.ForeColor = Color.Black;
            if (Kodikos1.Text == "Κωδικός" || Kodikos1.Text == "Παρακαλώ συμπληρώστε κωδικό")
            {

                Kodikos1.Text = "";
                Kodikos1.ForeColor = Color.Black;
                Kodikos1.PasswordChar = '*';
            }

        }

        private void Kodikos2_MouseClick(object sender, EventArgs e)
        {
            Kodikos2.ForeColor = Color.Black;
            if (Kodikos2.Text == "Επαλήθευση Κωδικού" || Kodikos2.Text == "Παρακαλώ συμπλήρωστε Κωδικό Επαλήθευσης")
            {

                Kodikos2.Text = "";
                Kodikos2.ForeColor = Color.Black;
                Kodikos2.PasswordChar = '*';
            }
        }
        Boolean deiktislathwn;
        private Boolean AllCheck()
        {

            deiktislathwn = true;

            if (Onoma.Text == "Όνομα" || Onoma.Text == "" || Onoma.Text == "Παρακαλώ συμπληρώστε όνομα")
            {
                deiktislathwn = false;
            }
            else if (Epitheto.Text == "Επώνυμο" || Epitheto.Text == "" || Epitheto.Text == "Παρακαλώ συμπληρώστε επώνυμο")
            {
                deiktislathwn = false;
            }
            else if (Email1.Text == "" || Email1.Text == "" || Email1.Text == "Παρακαλώ συμπληρώστε Εmail")
            {
                deiktislathwn = false;
            }
            else if (Kodikos1.Text == "" || Kodikos1.Text == "" || Kodikos1.Text == "Παρακαλώ συμπληρώστε κωδικό")
            {
                deiktislathwn = false;
            }
            else if (address.Text == "Περιοχή" || address.Text == "" || address.Text == "Παρακαλώ συμπληρώστε διέυθυνση")
            {
                deiktislathwn = false;
            }
            else if (Kodikos2.Text == "Επαλήθευση Κωδικού" || Kodikos2.Text == "" || Kodikos2.Text == "Παρακαλώ συμπλήρωσε Κωδικό Επαλήθευσης")
            {
                deiktislathwn = false;
            }
            else if (Kodikos1.Text == "Κωδικός" || Kodikos1.Text == "" || Kodikos1.Text == "Παρακαλώ συμπληρώστε κωδικό")
            {
                deiktislathwn = false;
            }
            else if (IBAN.Text == "IBAN" || IBAN.Text=="" || IBAN.Text =="Παρακαλώ συμπλήρωστε IBAN") {
                deiktislathwn = false;
            }
            else if (checksamepass = false)
            {
                deiktislathwn = false;
            }
            else if (emailcheck = false)
            {
                deiktislathwn = false;
            }
            else if (checkpassIsValid = false)
            {
                deiktislathwn = false;
            }

            return deiktislathwn;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (deiktislathwn == true)
            {
                var selectedGendreRadioButton = radioButtonBox.Controls.OfType<RadioButton>()
                               .FirstOrDefault(n => n.Checked);
                var genderText = "";

                if (selectedGendreRadioButton == maleRadioButton)
                {
                    genderText = "Male";
                }
                else
                {
                    genderText = "Female";
                }
                //eggrafi sti vasi

                
            }  }
        Boolean checkpassIsValid;

        private void Kodikos1_Leave(object sender, EventArgs e)
        {
            checkpassIsValid = true;
            passwordLabel.Visible = false;
            if (Kodikos1.TextLength == 0)
            {
                Kodikos1.ForeColor = Color.Red;
                Kodikos1.Text = "Παρακαλώ συμπληρώστε κωδικό";
                Kodikos1.PasswordChar = '\0';
            }
            else
            {
                if (!App_Code.StaticMethods.ValidationCheck.PasswordIsValid(Kodikos1.Text))
                {
                    passwordLabel.Visible = true;
                    passwordLabel.Text = "Ο κωδικός πρέπει να περιέχει τουλάχιστον 8 χαρακτήρες ,νούμερο, κεφαλαιο και μικρό γράμμα.";
                    checkpassIsValid = false;
                }



            }
        }
        private void Onoma_Leave(object sender, EventArgs e)
        {
            if (Onoma.Text == "")
            {
                Onoma.ForeColor = Color.Red;
                Onoma.Text = "Παρακαλω συμπλήρωστε όνομα";
            }
        }

        private void Epitheto_Leave(object sender, EventArgs e)
        {
            if (Epitheto.Text == "")
            {
                Epitheto.ForeColor = Color.Red;
                Epitheto.Text = "Παρακαλώ συμπλήρωστε επώνυμο";

            }
        }

        private void username1_Leave(object sender, EventArgs e)
        {
            usernameLabel.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            if (username1.Text == "")
            {
                username1.ForeColor = Color.Red;
                username1.Text = "Παρακαλώ συμπλήρωστε ψευδόνυμο";
            }
            else
            {
                if (App_Code.StaticMethods.ValidationCheck.CheckUserName(username1.Text))
                {
                    usernameLabel.Visible = true;
                    usernameLabel.Text = "Το ψευδόνυμο που επιλέξατε χρησιμοποιείται ήδη.";
                }
            }
            Cursor.Current = Cursors.Default;
        }


        private void Kodikos2_Leave(object sender, EventArgs e)
        {
            confimrpassLabel.Visible = false;
            if (Kodikos2.TextLength == 0)
            {
                Kodikos2.ForeColor = Color.Red;
                Kodikos2.Text = "Παρακαλώ συμπλήρωστε Κωδικό Επαλήθευσης";
                Kodikos2.PasswordChar = '\0';

            }
            else
            {
                confirmpasswords();

            }
        }
        //methodos pou elegxei ean oi kwdikoi einai idioi, ean den einai thetei tin timi checksamepass = false gia tin checkall()
        Boolean checksamepass = true;
        private void confirmpasswords()
        {

            checksamepass = true;
            confimrpassLabel.Visible = false;

            if (!App_Code.StaticMethods.ValidationCheck.ConfirmPasswordIsValid(Kodikos1.Text, Kodikos2.Text))
            {
                confimrpassLabel.Visible = true;
                confimrpassLabel.Text = "Ο κωδικός δεν ταιριάζει.";
                checksamepass = false;
            }


        }
        private void address_Leave(object sender, EventArgs e)
        {
            if (address.TextLength == 0)
            {
                address.ForeColor = Color.Red;
                address.Text = "Παρακαλώ συμπληρώστε διέυθυνση";
            }

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            if (!AllCheck())
            {
                Register.Enabled = false;
            }
            else
            {
                Register.Enabled = true;
            }
        }


        private void IBAN_Leave(object sender, EventArgs e)
        {
            if (IBAN.Text == "")
            {
                IBAN.ForeColor = Color.Red;
                IBAN.Text = "Παρακαλώ συμπληρώστε IBAN";
            }
        }

        Boolean emailcheck;
        private void Email1_Leave(object sender, EventArgs e)
        {
            emailcheck = true;
            emailLabel.Visible = false;

            Cursor.Current = Cursors.WaitCursor;
            if (Email1.Text == "" || Email1.Text == "Email")
            {
                Email1.ForeColor = Color.Red;
                Email1.Text = "Παρακαλω συμπλήρωστε Email";
            }
            else if (!App_Code.StaticMethods.ValidationCheck.EmailIsValid(Email1.Text))
            {
                emailLabel.Visible = true;
                emailLabel.Text = "To email δεν είναι έγκυρο.";
                emailcheck = false;
            }
            else
            {
                if (App_Code.StaticMethods.ValidationCheck.CheckEmail(Email1.Text))
                {
                    emailLabel.Visible = true;
                    emailLabel.Text = "Υπάρχει ήδη λογαριασμός με αυτό το email.";
                    emailcheck = false;
                }
            }
            Cursor.Current = Cursors.Default;
        }

       }
}

