using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code.Exceptions
{
    class TicketException : Exception
    {
        public TicketException(String msg) : base(msg)
        {

        }
        public TicketException() { }
    }
}
