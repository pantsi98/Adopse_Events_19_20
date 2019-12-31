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
            int imgIndex = 0;
            int tileIndex = 0;
            int panelIndex = 0;
            Control eventsTile;
            Control.ControlCollection tiles = this.Controls;

            //int indexImg = 0;
            //int indexEv = 0;
            List<Event> events = App_Code.StaticMethods.Events.events;
            List<Event> catevents = new List<Event>();
            List<Categories> categories = Categories.categories;
            Categories catev;
            Categories catfather;

            catevents = events.FindAll(x => x.GetCategory() == cat);
            catev = categories.Find(x => x.GetID() == cat);
            catfather = categories.Find(x => x.GetFather() == cat);
            titleLabel.Text = catev.GetName();


            for (int i = 0; i <= 10; i++)
            {
                eventsTile = tiles[tiles.Count - panelIndex - 1].Controls[tiles[tiles.Count - panelIndex - 1].Controls.Count - tileIndex - 1];
                if (catevents.Count > i)
                {
                    foreach (Control v in eventsTile.Controls)
                    {
                        if (v is PictureBox)
                        {
                            PictureBox eventPic = (PictureBox)v;
                            Image rszimg = Images.resizeImage(Images.pic.ElementAt(imgIndex), new Size(241, 110));
                            eventPic.Image = rszimg;
                            imgIndex++;
                        }
                        if (v is Label)
                        {
                            Label lb = (Label)v;
                            lb.Text = catevents.ElementAt(i).GetTitle();
                            eventsTile.Visible = true;
                        }
                    }
                }
                else
                {
                    eventsTile.Visible = false;
                }

                tileIndex++;
                if (tileIndex == 4)
                {
                    panelIndex++;
                    tileIndex = 0;
                }
                if (panelIndex == 3)
                {
                    panelIndex = 0;
                    break;
                }
            }
            #region commetns
            /*foreach (Control i in this.Controls)
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
            }*/
            #endregion
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
                        enventDataSetTableAdapters.eventsTableAdapter ev1 = new enventDataSetTableAdapters.eventsTableAdapter();
                        int event_id = (int)ev1.getIdFromTitle(a.Text);
                        evd = new EventFullDescription(event_id);
                    }
                }
            }

            parent.Controls.Clear();
            parent.Controls.Add(evd);
        }
    }
}
