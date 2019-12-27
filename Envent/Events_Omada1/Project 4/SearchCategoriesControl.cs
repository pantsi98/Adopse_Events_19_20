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
    public partial class SearchCategoriesControl : UserControl
    {
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
            List<Event> events = App_Code.StaticMethods.Events.events;
            List<Event> catevents = new List<Event>();
            List<Categories> categories = Categories.categories;
            Categories catev;

            catevents = events.FindAll(x => x.GetCategory() == cat);
            catev = categories.Find(x => x.GetID() == cat);
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
                                pic.Image = Images.pic.ElementAt(indexImg);
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
    }
}
