using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.App_Code.StaticMethods;

namespace Project_4.User_Classes
{
    public abstract class RegisteredUser : User
    {
        protected int userID;
        private string userName;
        private string passWord;

        public RegisteredUser(string userName, string passWord)
        {
            try
            {
                enventDataSetTableAdapters.userTableAdapter id = new enventDataSetTableAdapters.userTableAdapter();
                this.userID = id.getID(userName).ToList().ElementAt(0).id;
            
            }
            catch(Exception ex)
            {
                enventDataSetTableAdapters.adminTableAdapter id1 = new enventDataSetTableAdapters.adminTableAdapter();
                this.userID = id1.getID(userName).ToList().ElementAt(0).id;
            }
                
                this.userName = userName;
                this.passWord = passWord;    
        }
        public string GetPass()
        {
            return passWord;
        }
        public string GetUserName()
        {
            return userName;
        }
        public void LogOut()
        {
            InstanceOfUser.LogOut();
        }

        public int GetUserID()
        {
            return this.userID;
        }

        //Waiting for UI
        public override void ShowEventDeails(int id)
        {
            throw new NotImplementedException();
        }
        //Waiting for UI
        public override List<Event> ShowEvents()
        {
            throw new NotImplementedException();
        }

        public abstract Profile GetProfile();
    }
}
