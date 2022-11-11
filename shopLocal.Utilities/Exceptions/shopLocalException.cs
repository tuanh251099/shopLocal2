using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Utilities.Exxeptions
{
    public class shopLocalException : Exception
    {
        public shopLocalException()
        {

        }
        public shopLocalException(string message): base(message)
        {

        }
        public shopLocalException(string message, Exception inner): base(message, inner)
        {

        }
    }
}
