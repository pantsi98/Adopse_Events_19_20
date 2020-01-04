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
using System.Threading;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Splash_Animation sa = new Splash_Animation();
            sa.SetDesktopLocation(500, 500);
            sa.Show();
            Events.FillEventsData();
            Images.LoadImages();
            InstanceOfUser.CreateVisitor();
            Categories.FillCategoryData();
            sa.Close();
            Application.Run(new Form1());
        }

        //public InvokeThreadSafeForm()
        //{
            
        //}
    }
}
