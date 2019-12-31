using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.User_Classes;
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;

namespace Project_4
{
    public partial class BookingStep2 : UserControl
    {
        public BookingStep2()
        {
            InitializeComponent();
        }

        public BookingStep2(string date, string pay_type, int normal , int reduced)
        {
            InitializeComponent();
            User x = InstanceOfUser.GetUser();
            NormalUser nr = (NormalUser)x;
           name_label.Text = nr.GetProfile().GetLastName() + " " + nr.GetProfile().GetFirstName();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
