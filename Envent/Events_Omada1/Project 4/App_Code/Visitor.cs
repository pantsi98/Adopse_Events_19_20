using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;
//author Τζέιμς Μπαλάση
namespace Project_4.User_Classes
{
    public class Visitor : User
    {

        public void signUpAsUser(UserProfile profile,string userName, string passWord,List<int> prefferences)
        {
            enventDataSetTableAdapters.userTableAdapter singUp = new enventDataSetTableAdapters.userTableAdapter();
            if (checkUserName(userName))
            {
                singUp.registerAsUser(profile.GetFirstName(), profile.GetLastName(), userName, passWord, profile.GetEmail(), profile.GetAddress(), profile.GetGender(), profile.GetDob());
                if (prefferences.Count > 0)
                {
                    enventDataSetTableAdapters.preffered_categoriesTableAdapter prefference = new enventDataSetTableAdapters.preffered_categoriesTableAdapter();
                    int id = Convert.ToInt32(singUp.getID(userName));
                    foreach(int i in prefferences)
                    {
                        prefference.insertPrefference(id, i);
                    }
                }
            }
            else
            {
                throw new Exceptions.UserNameException("User name is already in use");
            }
        }

        public bool checkUserName(string userName)
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

        public User logInAsNormalUser(string userName,string passWord)
        {
            InstanceOfUser.CreateCustomerUser(userName,passWord);
            return InstanceOfUser.GetUser();
        }

        public User logInAsEventManager(string userName, string passWord)
        {
            InstanceOfUser.CreateEventManager(userName,passWord);
            return InstanceOfUser.GetUser();
        }

        public override void ShowEvents()
        {
            throw new NotImplementedException();
        }

        public override void ShowEventDeails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
