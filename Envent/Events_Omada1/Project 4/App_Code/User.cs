using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Project_4.App_Code.StaticMethods;
//Author Τζέιμς Μπαλάση

namespace Project_4.User_Classes
{
    public abstract class User
    {

        public abstract void ShowEvents();

        public abstract void ShowEventDeails(int id);

        public List<String> SearchForEvent(string keyWord)
        {

            var valid = new Regex(@"^.*" + keyWord + ".*$");
            List<string> results = new List<string>();
            foreach (string i in Events.events)
            {
                if (valid.IsMatch(i))
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}