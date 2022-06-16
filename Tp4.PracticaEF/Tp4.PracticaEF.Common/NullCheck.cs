using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp4.PracticaEF.Commons
{
    public class Methods
    {
        public static void NullCheck(object x)
        {
            
            
                if (x == null)
                {
                    throw new CustomException("No se encontro un Id que coincida con el ingresado");
                }
           

        }


    }
}