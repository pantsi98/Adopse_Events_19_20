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
    public partial class ProfileEventManager : UserControl
    {
        public ProfileEventManager()
        {
            InitializeComponent();
        }

        private void EmanPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createnewevent_Click(object sender, EventArgs e)
        {
            empanel.Controls.Clear();
            CreateNewEvent su = new CreateNewEvent();
            empanel.Controls.Add(su);

        }

        private void history_Click(object sender, EventArgs e)
        {

        }
    }
}
