using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    public class UserProfile : Profile
    {

        public UserProfile(string fname, string lname, string email, string address, string gender, DateTime dob) 
        : base(fname,lname,email,address,gender,dob)
        {
        }

    }
}
