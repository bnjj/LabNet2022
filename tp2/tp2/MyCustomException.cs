using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public  class MyCustomException : Exception
    {

        public MyCustomException() :base("Soy una Excepcion personalizada, Buenos dias Usuario")
        {
        }

      
    }
}
