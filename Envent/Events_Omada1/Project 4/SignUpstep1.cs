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
    public partial class SignUpstep1 : UserControl
    {
        public SignUpstep1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegister.Controls.Clear();
            SignUpUser su = new SignUpUser();
            panelRegister.Controls.Add(su);

        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventManagerButton_Click(object sender, EventArgs e)
        {
            panelRegister.Controls.Clear();
            SignUpAdmin1 su = new SignUpAdmin1();
            panelRegister.Controls.Add(su);
        }
    }
}
