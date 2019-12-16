using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes.Exceptions
{
    class FailLogInAsNormaillUser : Exception
    {
        public FailLogInAsNormaillUser(string msg) : base(msg)
        {
        }

        public FailLogInAsNormaillUser()
        {

        }

    }
}
