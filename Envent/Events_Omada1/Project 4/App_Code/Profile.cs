using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    public abstract class Profile
    {
        private string fname;
        private string lname;
        private string email;
        private string address;
        private List<Event> eventList;
        private string gender;
        private DateTime dob;

        public Profile(int userID)
        {
            enventDataSetTableAdapters.userTableAdapter pro = new enventDataSetTableAdapters.userTableAdapter();
            List<enventDataSet.userRow> results =  pro.getProfile(userID).ToList();
            this.fname = results.ElementAt(0).fname;
            this.lname = results.ElementAt(0).lname;
            this.email = results.ElementAt(0).email;
            this.address = results.ElementAt(0).address;
            this.gender = results.ElementAt(0).gender;
            this.dob = results.ElementAt(0).dob;
        }

        public Profile(string fname, string lname, string email, string address, string gender, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.dob = dob;
        }
        public Profile(int userID,bool admin)
        {
            enventDataSetTableAdapters.adminTableAdapter pro = new enventDataSetTableAdapters.adminTableAdapter();
            List<enventDataSet.adminRow> results = pro.getProfile(userID).ToList();
            this.fname = results.ElementAt(0).fname;
            this.lname = results.ElementAt(0).lname;
            this.email = results.ElementAt(0).email;
            this.address = results.ElementAt(0).address;
            this.gender = results.ElementAt(0).gender;
            this.dob = results.ElementAt(0).dob;
        }

        public string GetLastName (){
            return lname;
        }

        public string GetFirstName()
        {
            return fname;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetGender()
        {
            return gender;
        }

        public DateTime GetDob()
        {
            return dob;
        }

        public abstract void UpdateFirstName(int id, string fname);

        public abstract void UpdateLastName(int id, string lname);

        public abstract void UpdateEmail(int id, string email);

        public abstract void UpdateAddress(int id, string address);

        public abstract void UpdateUserName(int id, string userName);

        public abstract void UpdatePassword(int id, string password);
    }
}