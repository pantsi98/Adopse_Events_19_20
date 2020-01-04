using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code.StaticMethods;

namespace Project_4
{
    public partial class Splash_Animation : Form
    {

        private BufferedPanel panel;
        private Loader loader;

        public Splash_Animation()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;

            panel = new BufferedPanel();

            loader = new Loader(panel);

            //this.Controls.Add(panel);
            //panel.Location = new Point(350, 0);
            //panel.BackColor = System.Drawing.Color.Transparent;
            //panel.BringToFront();
        }
    }
}
