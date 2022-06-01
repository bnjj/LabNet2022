using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public  class Logic 
    {
        public static void ThrowSomeException()
        {
            throw new ArithmeticException();
          
        }
       public static void ThrowMyCustomException()
        {
            Console.WriteLine("Punto 4 ");
            Console.WriteLine("Presiona enter y vamos a tirar una excepcion personalizada");
            Console.ReadLine();
            try
            {
                throw new MyCustomException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
      
            }
            Console.ReadLine();

            
        }
        
    }
}
