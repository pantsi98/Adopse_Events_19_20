using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D; //must*
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.App_Code
{
    //Αυτη η κλάση είναι για τη δημιουργία του στρογγυλού εικονιδίου προφιλ/facebook/instagram....
    public class CCircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}