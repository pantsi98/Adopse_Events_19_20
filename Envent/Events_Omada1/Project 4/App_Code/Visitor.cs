using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//author Τζέιμς Μπαλάση
namespace Project_4.User_Classes
{
    public static class Visitor
    {

        public static void signUpAsUser(UserProfile profile,string userName, string passWord)
        {
            enventDataSetTableAdapters.userTableAdapter singUp = new enventDataSetTableAdapters.userTableAdapter();
            if (checkUserName(userName))
            {
                singUp.registerAsUser(profile.getFirstName(), profile.getLastName(), userName, passWord, profile.getEmail(), profile.getAddress(), profile.getGender(), profile.getDob());
            }
            else
            {
                throw new Exceptions.UserNameException("User name is already in use");
            }
        }

        public static bool checkUserName(string userName)
        {
            enventDataSetTableAdapters.userTableAdapter checkUserName = new enventDataSetTableAdapters.userTableAdapter();
            if (Convert.ToInt32(checkUserName.tryLogInAsUser(userName)) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static RegisteredUser logInAsNormalUser(string userName,string passWord)
        {

            RegisteredUser test = new RegisteredUser();
            return test;
        }


        /*public Admin logInAsAdmin(string userName, string passWord)
        {
            return test;
        }*/

        public static EventManager logInAsEventManager(string userName, string passWord)
        {
            EventManager test = new EventManager();
            return test;
        }
    }
}
