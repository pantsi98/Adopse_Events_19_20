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

        private void ProfileEventManager_Load(object sender, EventArgs e)
        {

        }

        private void UserButon_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmanPanel.Controls.Clear();
            HistoryEventManager su = new HistoryEventManager();
            EmanPanel.Controls.Add(su);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmanPanel.Controls.Clear();
            CreateNewEvent su = new CreateNewEvent();
            EmanPanel.Controls.Add(su);

        }
    }
}
