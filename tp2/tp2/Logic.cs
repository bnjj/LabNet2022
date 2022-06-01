using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public  class Logic : Exception
    {
        public static void ThrowSomeException()
        {
            throw new ArithmeticException();
          
        }
    }
}
