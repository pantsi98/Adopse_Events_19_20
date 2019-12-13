using System;
using System.Collections.Generic;
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
            profile = new UserProfile(userID);
        }
        public override Profile GetProfile(int userID)
        {
            return profile;
        }
    }
}
