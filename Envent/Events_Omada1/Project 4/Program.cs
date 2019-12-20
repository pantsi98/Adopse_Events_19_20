using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.App_Code.StaticMethods;
using System.Net;
using System.Drawing;
using System.IO;

namespace Project_4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Events.FillEventsData();
            WebClient cli = new WebClient();
            List<string> imgUrls = new List<string>();
            for(int i=0; i<Events.events.Count; i++)
            {
                imgUrls.Add(Events.events.ElementAt(i).GetImage());
                cli.DownloadFile(imgUrls.ElementAt(i), @"C:\Users\dimosthenisgr\Documents\GitHub\Adopse_Events_19_20\Envent\Events_Omada1\Project 4\Resources\eventImg"+i+".jpg");
                Images.pic.Add(Image.FromFile(@"C:\Users\dimosthenisgr\Documents\GitHub\Adopse_Events_19_20\Envent\Events_Omada1\Project 4\Resources\eventImg"+i+".jpg"));
            }
            InstanceOfUser.CreateVisitor();
            Categories.FillCategoryData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
