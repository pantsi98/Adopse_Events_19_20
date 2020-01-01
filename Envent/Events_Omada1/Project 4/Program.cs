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
using Project_4.App_Code;

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
            InstanceOfUser.CreateVisitor();
            Venue.FillVenuesData();
            Play.FillPlaysData();
            Events.FillEventsData();
            Images.LoadImages();
            Categories.FillCategoryData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}