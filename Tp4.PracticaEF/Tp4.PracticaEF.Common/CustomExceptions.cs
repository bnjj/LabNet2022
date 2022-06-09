using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.PracticaEF.Common
{
    public class CantBeNullException : Exception
    {
        public CantBeNullException(string message)
       : base(message)
        {
        }
    }
   
}
