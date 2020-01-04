using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.User_Classes;

namespace Project_4.App_Code
{
    public class NormalUser : RegisteredUser
    {
        UserProfile profile;

        public NormalUser(string userName, string passWord) : base(userName,passWord)
        {
            if (userID != null )
            {
                profile = new UserProfile(userID);
                Debug.WriteLine("to user id einai: " + userID);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("no param ston userid");
                Debug.WriteLine("no param sto user id");
            }
        }
        public override Profile GetProfile()
        {
            return profile;
        }
    }
}
