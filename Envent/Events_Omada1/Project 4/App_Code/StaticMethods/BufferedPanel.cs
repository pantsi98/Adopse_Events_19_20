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
            SetStyle(ControlStyles.Opaque, true);
            this.Width = 100;
            this.Height = 100;

        }
    }
}
