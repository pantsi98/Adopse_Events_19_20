using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    class Admin
    {
        private List<RegisteredUser> Users;
        private string userName;
        private string passWord;
        private string userID;

        public Admin(string userName,string passWord)
        {

            this.userName = userName;
            this.passWord = passWord;

        }

        override
        public void showEvents() {}
        
        public Admin ()
        {
            
        }

        public void editProfile(Profile profile)
        {

        }

        public void deleteProfile(Profile profile)
        {

        }

        public void editEvents(Event events)
        {

        }
        public void showEventDetails(int id)
        {

        }
    }
}
