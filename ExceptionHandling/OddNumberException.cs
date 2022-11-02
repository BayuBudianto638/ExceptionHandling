using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class OddNumberException: Exception
    {
        public OddNumberException()
        {

        }

        public OddNumberException(string message): base(message)
        {

        }

        public OddNumberException(string message, Exception inner): base(message, inner)
        {

        }

        //public override string Message
        //{
        //    get
        //    {
        //        return "Divisor can not be odd number!";
        //    }
        //}

        public override string HelpLink 
        {
            get
            {
                return "Get info call Han Han Hanafi https://www.google.com/";
            }
        }
    }
}
