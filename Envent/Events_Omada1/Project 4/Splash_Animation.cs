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

            panel = new BufferedPanel();
            panel.Dock = DockStyle.Right;

            loader = new Loader(panel);

            this.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 100);
            panel.BringToFront();
        }
    }
}
