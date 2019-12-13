using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    public class UserProfile : Profile
    {

        public UserProfile(int userName) : base(userName)
        {
        }

        public UserProfile(string fname, string lname, string email, string address, string gender, DateTime dob)
        : base(fname, lname, email, address, gender, dob)
        {
        }

        public override void UpdateAddress(int id, string address)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updateAddress(address, id);
        }

        public override void UpdateEmail(int id, string email)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updateEmail(email, id);
        }

        public override void UpdateFirstName(int id, string fname)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updateFirstName(fname, id);
        }

        public override void UpdateLastName(int id, string lname)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updateLastName(lname, id);
        }

        public override void UpdateUserName(int id, string userName)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updateUserName(userName, id);
        }

        public override void UpdatePassword(int id, string password)
        {
            enventDataSetTableAdapters.userTableAdapter up = new enventDataSetTableAdapters.userTableAdapter();
            up.updatePassword(password, id);
        }
    }
}
