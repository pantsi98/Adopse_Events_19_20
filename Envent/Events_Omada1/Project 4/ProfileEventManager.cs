using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code;
using Project_4.User_Classes;
using Project_4.App_Code.StaticMethods;

namespace Project_4
{
    public partial class ProfileEventManager : UserControl
    {
        User x = InstanceOfUser.GetUser();
        public bool datachange = false;
        public int Id;
        public string onoma;
        public string lastname;
        public string email;
        public string adress;
        public string usrname;
        public DateTime dob;
        public ProfileEventManager()
        {
            InitializeComponent();
        }

        private void EmanPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createnewevent_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CreateNewEvent su = new CreateNewEvent();
            panel1.Controls.Add(su);

        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void ProfileEventManager_Load(object sender, EventArgs e)
        {

        }
    }
}
