using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.User_Classes;
using Project_4.App_Code.StaticMethods;
namespace Project_4
{
    public partial class HomeMain : UserControl
    {
        public HomeMain()
        {
            InitializeComponent();
        }

        private void HomeMain_Load(object sender, EventArgs e)
        {

             int index = 0;
             User user = InstanceOfUser.GetUser();
             List<Event> events = new List<Event>();
            foreach(Event ev in user.ShowEvents())
            {
                if(ev.GetCategory())
            }

             List<Categories> cat = Categories.categories;
             foreach (Control p in musicPanel.Controls)
             {
                 foreach (Control i in p.Controls)
                 {
                     if (i is PictureBox)
                     {
                         PictureBox pic = (PictureBox)i;
                         pic.Image = Images.pic.ElementAt(index);
                     }
                     if (i is Label)
                     {
                         Label lb = (Label)i;
                         lb.Text = events.ElementAt(index).GetTitle();
                     }
                     index++;
                 }
             }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
