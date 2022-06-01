using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public static class Methods
    {

        public static int Divide100By(this int divisor)
        {
            try
            {
               
                Console.WriteLine("Resultado {0}", 100/divisor);
                return 100/divisor;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Programa termino");
                
            }
            return divisor;

        }
        public static int Division()
        {

            try
            {
                Console.WriteLine("Ingrese un divisor");
                int dividend = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un dividendo");
                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine("Resultado de la operacion : {0}", dividend / divisor);
                return dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris puede dividir en 0 mi rey. Mensaje de excepcion --> "+ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada ! -_- ");
            }
             finally { 
                Console.WriteLine("Programa termino.");
            }
            return 0;
        }

    }
}
