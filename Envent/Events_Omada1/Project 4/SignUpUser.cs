using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Project_4
{
    public partial class SignUpUser : UserControl
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {

        }

        String gender = "";
        String fname = "";
        String lname = "";
        String username = "";
        String email = "";
        String password = "";
        String interest = "";
        String imera = "";
        String minas = "";
        String etos = "";
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
            if (Epitheto.Text == "Επώνυμο" || Epitheto.Text == "Συμπλήρωσε Επίθετο")
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
        private void address_MouseClick(object sender, MouseEventArgs e)
        {
            address.ForeColor = Color.Black;
            if (address.Text == "Περιοχή" || address.Text == "Συμπλήρωσε Περιοχή")
            {

                address.Text = "";
                address.ForeColor = Color.Black;

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
       /* private void domainUpDown1_Click(object sender, EventArgs e)
        {
            domainUpDown1.ForeColor = Color.Black;

        } */




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



        //elegxei ean o xristis exei sumplirwsei ola ta pedia swsta, ean oxi tou emfanizei minima kai kanei ton
        //analogo deikti txt false 

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
                Epitheto.Text = "Συμπλήρωσε Επίθετο";
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
            if (Kodikos1.Text == "" || Kodikos1.Text == "Κωδικός")
            {

                Kodikos1.ForeColor = Color.Red;
                Kodikos1.Text = "Συμπλήρωσε Kωδικό";
                deiktislathwn = true;


            }

            if (address.Text == "" || address.Text == "Περιοχή")
            {

                address.ForeColor = Color.Red;
                address.Text = "Συμπλήρωσε Περιοχή";
                deiktislathwn = true;


            }
            if (Kodikos2.Text == "" || Kodikos2.Text == "Επαλήθευση Κωδικού")
            {

                Kodikos2.ForeColor = Color.Red;
                Kodikos2.Text = "Συμπλήρωσε Κωδικό Επαλήθευσης";
                deiktislathwn = true;



            }
            /*if (domainUpDown1.Text == "Μήνας")
            {

                domainUpDown1.ForeColor = Color.Red;
                deiktislathwn = true;

            }*/

            /*if (!Andras.Checked && !Gynaika.Checked)
            {

                fullolabel.ForeColor = Color.Red;
                deiktislathwn = true;

            }*/


            if (checkPasswords() == false)
            {
                messageLabel.Visible = true;
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Οι κωδικοί δεν είναι ίδιοι, ξαναπροσπαθήστε .";
                deiktislathwn = true;

            }
            return deiktislathwn;

        }



        //methodoi wste na einai mono ena checkbox checked
        private void Andras_CheckedChanged(object sender, EventArgs e)
        {
            /*Gynaika.Checked = !Andras.Checked;
            gender = "andras";*/


        }

        private void Gynaika_CheckedChanged(object sender, EventArgs e)
        {
            /*Andras.Checked = !Gynaika.Checked;
            gender = "gunaika";*/

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

        private void address_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "Περιοχή";
                address.ForeColor = Color.DimGray;


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

        private void Gynaika_Click(object sender, EventArgs e)
        {
            fullolabel.ForeColor = Color.FromArgb(86, 128, 233);
        }

        private void Andras_Click(object sender, EventArgs e)
        {
            fullolabel.ForeColor = Color.FromArgb(86, 128, 233);
        }

        private void dateofBirth() {
            String dateofBirth;
            //imera = numericUpDown1.Value.ToString();
           // minas = domainUpDown1.Text.ToString();
            //etos = numericUpDown2.Value.ToString();
            if (minas == "Ιαν")
                dateofBirth = String.Concat(imera + 01 + etos);
            if (minas == "Φεβ")
                dateofBirth = String.Concat(imera + 02 + etos);
            if (minas == "Μάρ")
                dateofBirth = String.Concat(imera + 03+ etos);
            if (minas == "Απρ")
                dateofBirth = String.Concat(imera + 04 + etos);
            if (minas == "Μάι")
                dateofBirth = String.Concat(imera + 05 + etos);
            if (minas == "Ιούν")
                dateofBirth = String.Concat(imera + 06 + etos);
            if (minas == "Ιούλ")
                dateofBirth = String.Concat(imera + 07 + etos);
            if (minas == "Αύγ")
                dateofBirth = String.Concat(imera + 08 + etos);
            if (minas == "Σεπ")
                dateofBirth = String.Concat(imera + 09 + etos);
            if (minas == "Οκτ")
                dateofBirth = String.Concat(imera + 10 + etos);
            if (minas == "Νοέμ")
                dateofBirth = String.Concat(imera + 11 + etos);
            if (minas == "Δεκ")
                dateofBirth = String.Concat(imera + 12 + etos);


        }


        private void Register_Click(object sender, EventArgs e)
        {
            var buttons = radioButtonBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            User_Classes.UserProfile profile = new User_Classes.UserProfile(Onoma.Text,Epitheto.Text,Email1.Text,address.Text,
                buttons.Text,dobPicker.Value);
            string userName = username1.Text;
            string passWord = Kodikos1.Text;
            User_Classes.Visitor.signUpAsUser(profile, userName, passWord);
            #region close
            /*            if (AllCheck() == false)
                        {

                            //tote kane eggrafi sti vasi ta stoixeia toy xristi

                            fname = Onoma.Text;
                            lname = Epitheto.Text;
                            username = username1.Text;
                            email = Email1.Text;
                            password = Kodikos1.Text;
                            imera = numericUpDown1.Value.ToString();
                            minas = domainUpDown1.Text.ToString();
                            etos = numericUpDown2.Value.ToString();
                            dieuth = address.Text.ToString();


                            string cs = @"server=35.228.3.69;userid=root;password=l7heDyE6lxs7CN7o;database=enventDb";

                            var con = new MySqlConnection(cs);
                            con.Open();
                            if (con.State == System.Data.ConnectionState.Open)
                            {
                               /* String stm = "INSERT INTO `user` (`fname`, `lname`, `username`, `password`, `interests`, `email`, `address`, `created_at`, `last_login`, `gender`, `dob`) VALUES ('"+
                                    fname+"','"+lname + "','"+username+"','"+password+"','"+ @p5  + "','"+ email + "','" + dieuth + "','" + @p8e + "','" + @p9e + "','" + gender+"','"+dateofBirth +"')'";
                                MySqlCommand cmd = new MySqlCommand(stm, con);

                               cmd.ExecuteNonQuery();
                            }

                            con.Close();



                        }*/
            #endregion
        }





        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
