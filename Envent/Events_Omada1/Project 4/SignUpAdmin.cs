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
    public partial class SignUpAdmin : UserControl
    {
        public SignUpAdmin()
        {
            InitializeComponent();
        }

        String fname = "";
        String lname = "";
        String username = "";
        String email = "";
        String password = "";
        String iban = "";
        String dieuth = "";


        private void Onoma_MouseClick(object sender, MouseEventArgs e)
        {

            Onoma.ForeColor = Color.Black;
            if (Onoma.Text == "Όνομα" || Onoma.Text == "Συμπλήρωσε Όνομα")
            {

                Onoma.Text = "";
                Onoma.ForeColor = Color.Black;

            }

        }

        private void Epitheto_MouseClick(object sender, MouseEventArgs e)
        {
            Epitheto.ForeColor = Color.Black;
            if (Epitheto.Text == "Επώνυμο" || Epitheto.Text == "Συμπλήρωσε Επώνυμο")
            {

                Epitheto.Text = "";
                Epitheto.ForeColor = Color.Black;

            }

        }
        private void username1_MouseClick(object sender, MouseEventArgs e)
        {
            username1.ForeColor = Color.Black;
            if (username1.Text == "Username" || username1.Text == "Συμπλήρωσε Username")
            {

                username1.Text = "";
                username1.ForeColor = Color.Black;

            }
        }

        private void Email1_MouseClick(object sender, MouseEventArgs e)
        {
            Email1.ForeColor = Color.Black;
            if (Email1.Text == "Email" || Email1.Text == "Συμπλήρωσε Email")
            {

                Email1.Text = "";
                Email1.ForeColor = Color.Black;

            }
        }
        private void IBAN_MouseClick(object sender, MouseEventArgs e)
        {
            IBAN.ForeColor = Color.Black;
            if (IBAN.Text == "IBAN" || IBAN.Text == "Συμπλήρωσε IBAN")
            {

                IBAN.Text = "";
                IBAN.ForeColor = Color.Black;

            }

        }
        private void Kodikos1_MouseClick(object sender, MouseEventArgs e)
        {
            Kodikos1.ForeColor = Color.Black;
            if (Kodikos1.Text == "Κωδικός" || Kodikos1.Text == "Συμπλήρωσε Kωδικό")
            {

                Kodikos1.Text = "";
                Kodikos1.ForeColor = Color.Black;
                Kodikos1.PasswordChar = '*';
            }

        }

        private void Kodikos2_MouseClick(object sender, MouseEventArgs e)
        {
            Kodikos2.ForeColor = Color.Black;
            if (Kodikos2.Text == "Επαλήθευση Κωδικού" || Kodikos2.Text == "Συμπλήρωσε Κωδικό Επαλήθευσης")
            {

                Kodikos2.Text = "";
                Kodikos2.ForeColor = Color.Black;
                Kodikos2.PasswordChar = '*';
            }


        }

        //methodos pou elegxei ean o kodikos1 einai idios me ton kodiko2
        private Boolean checkPasswords()
        {
            Boolean cp = false;
            if (Kodikos1.Text == Kodikos2.Text)
            {
                cp = true;
            }
            else
            {
                Kodikos2.ForeColor = Color.Red;
                Kodikos1.ForeColor = Color.Red;
            }
            return cp;
        }



        private Boolean AllCheck()
        {

            Boolean deiktislathwn = false;
            messagefullo.Visible = false;
            messageLabel.Visible = false;

            if (Onoma.Text == "Όνομα" || Onoma.Text == "")
            {
                Onoma.ForeColor = Color.Red;
                Onoma.Text = "Συμπλήρωσε Όνομα";
                deiktislathwn = true;


            }

            if (Epitheto.Text == "" || Epitheto.Text == "Επώνυμο")
            {

                Epitheto.ForeColor = Color.Red;
                Epitheto.Text = "Συμπλήρωσε Επώνυμο";
                deiktislathwn = true;


            }
            if (username1.Text == "" || username1.Text == "Username")
            {

                username1.ForeColor = Color.Red;
                username1.Text = "Συμπλήρωσε Username";
                deiktislathwn = true;


            }

            if (Email1.Text == "" || Email1.Text == "Email")
            {
                Email1.ForeColor = Color.Red;
                Email1.Text = "Συμπλήρωσε Email";
                deiktislathwn = true;


            }
            if (IBAN.Text == "" || IBAN.Text == "IBAN")
            {
                IBAN.ForeColor = Color.Red;
                IBAN.Text = "Συμπλήρωσε IBAN";
                deiktislathwn = true;


            }
            if (Kodikos1.Text == "" || Kodikos1.Text == "Κωδικός")
            {

                Kodikos1.ForeColor = Color.Red;
                Kodikos1.Text = "Συμπλήρωσε Kωδικό";
                deiktislathwn = true;


            }
            if (Kodikos2.Text == "" || Kodikos2.Text == "Επαλήθευση Κωδικού")
            {

                Kodikos2.ForeColor = Color.Red;
                Kodikos2.Text = "Συμπλήρωσε Κωδικό Επαλήθευσης";
                deiktislathwn = true;



            }
            if (address.Text == "" || address.Text == "Περιοχή")
            {

                address.ForeColor = Color.Red;
                address.Text = "Συμπλήρωσε Περιοχή";
                deiktislathwn = true;


            }



            if (checkPasswords() == false)
            {
                messageLabel.Visible = true;
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Οι κωδικοί δεν είναι ίδιοι, ξαναπροσπαθήστε .";
                deiktislathwn = true;

            }
            return deiktislathwn;

        }


        private void Onoma_Leave(object sender, EventArgs e)
        {
            if (Onoma.Text == "")
            {
                Onoma.Text = "Όνομα";
                Onoma.ForeColor = Color.DimGray;


            }
        }

        private void Epitheto_Leave(object sender, EventArgs e)
        {
            if (Epitheto.Text == "")
            {
                Epitheto.Text = "Επώνυμο";
                Epitheto.ForeColor = Color.DimGray;


            }
        }
        private void username1_Leave(object sender, EventArgs e)
        {
            if (username1.Text == "")
            {
                username1.Text = "Username";
                username1.ForeColor = Color.DimGray;


            }


        }
        private void Email1_Leave(object sender, EventArgs e)
        {
            if (Email1.Text == "")
            {
                Email1.Text = "Email";
                Email1.ForeColor = Color.DimGray;


            }
        }

        private void IBAN_Leave(object sender, EventArgs e)
        {
            if (IBAN.Text == "")
            {
                IBAN.Text = "IBAN";
                IBAN.ForeColor = Color.DimGray;


            }

        }
        private void Kodikos1_Leave(object sender, EventArgs e)
        {
            if (Kodikos1.Text == "")
            {
                Kodikos1.Text = "Κωδικός";
                Kodikos1.ForeColor = Color.DimGray;
                Kodikos1.PasswordChar = '\0';

            }

        }

        private void Kodikos2_Leave(object sender, EventArgs e)
        {
            if (Kodikos2.Text == "")
            {
                Kodikos2.Text = "Επαλήθευση Κωδικού";
                Kodikos2.ForeColor = Color.DimGray;
                Kodikos2.PasswordChar = '\0';

            }

        }




        private void Register_Click(object sender, EventArgs e)
        {
            if (AllCheck() == false)
            {

                fname = Onoma.Text;
                lname = Epitheto.Text;
                username = username1.Text;
                email = Email1.Text;
                password = Kodikos1.Text;
                iban = IBAN.Text;
                dieuth = address.Text.ToString();




                string cs = @"server=35.228.3.69;userid=root;password=l7heDyE6lxs7CN7o;database=enventDb";

                var con = new MySqlConnection(cs);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    String stm = "INSERT INTO `admin` (`fname`, `lname`, `username`, `password`, `iban`, `email`, `address`) VALUES("+
                        fname + "','" + lname + "','" + username + "','" + password + "','" +iban+ "','" + email + "','" + dieuth+"')'";
                    MySqlCommand cmd = new MySqlCommand(stm, con);

                    cmd.ExecuteNonQuery();
                }
                con.Close();




            }
        }

        private void panel2_Leave(object sender, EventArgs e)
        {

        }

        private void address_MouseClick(object sender, MouseEventArgs e)
        {
            address.ForeColor = Color.Black;
            if (address.Text == "Περιοχή" || address.Text == "Συμπλήρωσε Περιοχή")
            {

                address.Text = "";
                address.ForeColor = Color.Black;

            }
        }

        private void address_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "Περιοχή";
                address.ForeColor = Color.DimGray;


            }
        }
    }
}
