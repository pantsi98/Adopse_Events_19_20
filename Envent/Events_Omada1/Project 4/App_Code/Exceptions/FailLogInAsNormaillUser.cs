using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes.Exceptions
{
    class FailLogInAsNormalUser : Exception
    {
        public FailLogInAsNormalUser(string msg) : base(msg)
        {
        }

        public FailLogInAsNormalUser()
        {

        }

    }
}
