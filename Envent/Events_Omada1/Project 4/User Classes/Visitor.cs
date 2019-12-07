using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//author Τζέιμς Μπαλάση
namespace Project_4.User_Classes
{
    class Visitor
    {

        public void registerUser(Profile profile)
        {

        }

        public RegisteredUser logInAsNormalUser(string userName,string passWord)
        {

            RegisteredUser test = new RegisteredUser();
            return test;
        }


        public Admin logInAsAdmin(string userName, string passWord)
        {
            Admin test = new Admin();
            return test;
        }

        public EventManager logInAsEventManager(string userName, string passWord)
        {
            EventManager test = new EventManager();
            return test;
        }
    }
}
