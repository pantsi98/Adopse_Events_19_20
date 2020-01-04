using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.App_Code.StaticMethods
{
    class BufferedPanel : Panel
    {

        public BufferedPanel() : base()
        {
            this.DoubleBuffered = true;
            this.Width = 350;
            this.Height = 350;
            this.BackColor = System.Drawing.Color.White;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
