using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code.StaticMethods;
using Project_4.User_Classes;
using Project_4.App_Code;

namespace Project_4
{
    public partial class ResetPassword : UserControl
    {
        
        
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtResetPass.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void button_reset_pass_Click(object sender, EventArgs e)
        {

            NormalUser nu = (NormalUser)InstanceOfUser.GetUser();
            int id = nu.GetUserID();
            UserProfile ru =  (UserProfile)nu.GetProfile();
            ru.UpdatePassword(id, txtResetPass.Text);
            recoverMsg.ForeColor = Color.Green;
            recoverMsg.Text = "Ο κωδικός άλλαξε επιτυχώς!";
        }
    }
}
