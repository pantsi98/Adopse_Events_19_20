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
using System.IO;
using System.Diagnostics;
using System.Net;

namespace Project_4
{
    public partial class SearchCategoriesControl : UserControl
    {

        EventFullDescription evd;

        public SearchCategoriesControl()
        {
            InitializeComponent();
        }

        public SearchCategoriesControl(int category)
        {
            InitializeComponent();
            SearchCategoriesControlPrepare(category);
        }

        private void SearchCategoriesControlPrepare(int cat)
        {
            int indexImg = 0;
            int indexEv = 0;
            Dictionary<int,int> catf = new Dictionary<int,int>();
            catf[1] = 0; catf[2] = 0; catf[3] = 0; catf[4] = 0; catf[5] = 0; catf[6] = 3; catf[7] = 3; catf[8] = 5; catf[9] = 5; catf[10] = 0;
            int dict = 1;
            List<Event> events = App_Code.StaticMethods.Events.events;
            List<Event> catevents = new List<Event>();
            List<Categories> categories = Categories.categories;
            Categories catev;
            Categories catfather;

            if (catf[cat] == 0)
            {
                catevents = events.FindAll(x => x.GetCategory() == cat || x.GetFather() == cat);
            }
            else if (catf[cat] != 0)
            {
                catevents = events.FindAll(x => x.GetCategory() == cat);
            }

            catev = categories.Find(x => x.GetID() == cat);
  
            //catfather = categories.Find(x => x.GetFather() == cat);
                

            Debug.WriteLine(catev.GetName());
            titleLabel.Text = catev.GetName();
            
            foreach (Control i in this.Controls)
            {
                foreach (Control k in i.Controls)
                {
                    foreach (Control p in k.Controls)
                    {
                        if (indexImg < catevents.Count)
                        {
                            if (p is PictureBox)
                            {
                                PictureBox pic = (PictureBox)p;
                                Image rszimg = Images.resizeImage(Images.pic.ElementAt(indexImg), new Size(241, 110));
                                pic.Image = rszimg;
                                indexImg++;
                            }
                            if (p is Label)
                            {
                                Label lb = (Label)p;
                                lb.Text = catevents.ElementAt(indexEv).GetTitle();
                                indexEv++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void TileClick(object sender, EventArgs e)
        {

            Control parent = this.Parent;
            while(parent.Name != "MainPanel")
            {
                parent = parent.Parent;
            }

            Control a = (Control)sender;
            if(a is Label)
            {
                enventDataSetTableAdapters.eventsTableAdapter ev1 = new enventDataSetTableAdapters.eventsTableAdapter();
                int event_id = (int)ev1.getIdFromTitle(a.Text);
                evd = new EventFullDescription(event_id);
            }
            else if(a is PictureBox)
            {
                Control parl = a.Parent;
                foreach( Control c in parl.Controls)
                {
                    if(c is Label)
                    {
                        try
                        {
                            enventDataSetTableAdapters.eventsTableAdapter ev1 = new enventDataSetTableAdapters.eventsTableAdapter();
                            int event_id = (int)ev1.getIdFromTitle(a.Text);
                            evd = new EventFullDescription(event_id);
                        }catch(Exception ex) { }
                    }
                }
            }

            parent.Controls.Clear();
            parent.Controls.Add(evd);
        }
    }
}
