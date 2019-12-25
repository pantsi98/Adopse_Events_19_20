using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code.StaticMethods
{
    public class Images
    {
        public static List<Image> pic = new List<Image>();

        public static void LoadImages()
        {
            string path = Directory.GetCurrentDirectory();
            string[] directories = path.Split(Path.DirectorySeparatorChar);
            path = "";
            for (int i = 0; i < directories.Length - 2; i++)
            {
                path += directories[i];
                path += "/";
            }
            Events.FillEventsData();
            WebClient cli = new WebClient();
            List<string> imgUrls = new List<string>();
            for (int i = 0; i < Events.events.Count; i++)
            {
                imgUrls.Add(Events.events.ElementAt(i).GetImage());
                if (!File.Exists(path + @"Resources\eventImg" + i + ".jpg"))
                {
                    cli.DownloadFile(imgUrls.ElementAt(i), path + @"Resources\eventImg" + i + ".jpg");
                }
                Images.pic.Add(Image.FromFile(path + @"Resources\eventImg" + i + ".jpg"));
            }
        }
    }
}