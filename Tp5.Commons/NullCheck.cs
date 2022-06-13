using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Entities;

namespace Tp5.Commons
{
   
   public class C
    {
        public static bool NullCheck(object x)
        {
            try
            { 
                if (x == null)
                {
                  
                    throw new CustomException("No se encontro un Id que coincida con el ingresado");
                    
                    
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }

        }
       
    }
}
