using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException
{
    internal class CheckScroreException : Exception
    {
        public CheckScroreException(string msg) 
            :base(msg) 
        {

        }
        
    }
    internal class CheckNameException : Exception
    {
        public CheckNameException(string msg)
            : base(msg)
        {

        }

    }
}
