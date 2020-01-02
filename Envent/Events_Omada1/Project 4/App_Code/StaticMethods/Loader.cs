using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.App_Code.StaticMethods
{
    class Loader
    {
        private BufferedPanel panel;
        public int x, y, w, h;
        private bool reverse = false;
        private int angle = 0;
        private Timer timer;
        private Pen pen;
    
        public Loader(BufferedPanel panel)
        {
            this.panel = panel;
            w = 75;
            h = 75;

            this.panel.Paint += draw;

            pen = new Pen(Color.White);

            timer = new Timer();
            timer.Interval = 1000 / 50;
            timer.Tick += update;
            timer.Start();

        }

        private void update(object sender, EventArgs e)
        {
            this.panel.Invalidate();
        }

        private void draw(object sender, PaintEventArgs e)
        {
            x = this.panel.Width / 2;
            y = this.panel.Height / 2;


            Graphics ctx = e.Graphics;
            ctx.SmoothingMode = SmoothingMode.HighQuality;

            ctx.DrawArc(pen, x, y, w, h, 0, 360);
        }
    }
}
