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

        public RegisteredUser logIn(string userName,string passWord)
        {
            RegisteredUser test = new RegisteredUser();
            return test;
        }

    }
}
