using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes.Exceptions
{
    class FailLoginAsEventManager : Exception
    {
        public FailLoginAsEventManager(string msg) : base(msg)
        {
        }

        public FailLoginAsEventManager()
        {

        }



    }
}
