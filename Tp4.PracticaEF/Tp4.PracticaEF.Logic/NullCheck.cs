using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Commons;

namespace Tp4.PracticaEF.Logic
{
   public class Methods
    {
        public static void NullCheck(object x,string typeOfCheck)
        {
            if(typeOfCheck=="idCheck")
            {
                if (x == null)
                {
                    throw new CustomException("No se encontro un Id que coincida con el ingresado");
                }
            }
            
        }


    }
}
