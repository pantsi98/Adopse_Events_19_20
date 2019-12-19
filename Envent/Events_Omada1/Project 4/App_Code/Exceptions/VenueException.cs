using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code.Exceptions
{
    class VenueException : Exception
    {
        public VenueException(String msg) : base(msg)
        {

        }
        public VenueException() { }
    }
}
