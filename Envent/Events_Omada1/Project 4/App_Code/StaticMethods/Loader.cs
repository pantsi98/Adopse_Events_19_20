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
        private int startAngle = 0;
    
        public Loader(BufferedPanel panel)
        {
            this.panel = panel;
            w = 130;
            h = 130;

            this.panel.Paint += draw;

            pen = new Pen(Color.FromArgb(86, 128, 233), 7);

            timer = new Timer();
            timer.Interval = 1000 / 50;
            timer.Tick += update;
            timer.Start();

        }

        private void update(object sender, EventArgs e)
        {
            this.panel.Invalidate();

            if (startAngle > 360)
            {
                reverse = true;
                startAngle = 360;
            }
            else if (startAngle < 0)
            {
                reverse = false;
                startAngle = 0;
            }

            if (!reverse)
            {
                startAngle += 3;
            }
            else
            {
                startAngle -= 3;
            }

            angle += 2;
        }

        private void draw(object sender, PaintEventArgs e)
        {
            x = this.panel.Width / 2;
            y = this.panel.Height / 2;


            Graphics ctx = e.Graphics;
            ctx.SmoothingMode = SmoothingMode.HighQuality;
            ctx.TranslateTransform(x, y);
            ctx.RotateTransform(angle);

            if (!reverse)
            {
                ctx.DrawArc(pen, -w/2, -h/2, w, h, startAngle, startAngle);
            }
            else
            {
                ctx.DrawArc(pen, -w/2, -h/2, w, h, 360-startAngle, startAngle);
            }
        }
    }
}
