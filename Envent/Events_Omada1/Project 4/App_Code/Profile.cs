using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    public class Profile
    {
        private string fname;
        private string lname;
        private string email;
        private string address;
        private List<Event> eventList;
        private string gender;
        private DateTime dob;

        public Profile(string fname, string lname, string email, string address, string gender, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.dob = dob;
        }

        public string getLastName (){
            return lname;
        }

        public string getFirstName()
        {
            return fname;
        }

        public string getEmail()
        {
            return email;
        }

        public string getAddress()
        {
            return address;
        }

        public string getGender()
        {
            return gender;
        }

        public DateTime getDob()
        {
            return dob;
        }
    }
}
