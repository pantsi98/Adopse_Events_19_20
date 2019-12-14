using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.User_Classes;
namespace Project_4.App_Code.StaticMethods
{
    public class InstanceOfUser
    {
        private static User user;

        public static User GetUser()
        {
            return user;
        }

        public static void CreateVisitor()
        {
            user = new Visitor();
        }

        public static void CreateCustomerUser(string userName, string passWord)
        {
            user = new NormalUser(userName,passWord);
        }

        public static void CreateEventManager(string userName, string passWord)
        {
            user = new EventManager(userName, passWord);  
        }

        public static void LogOut()
        {
            user = default(User);
        }
    }
}
