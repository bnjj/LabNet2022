using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto 1 
            Console.WriteLine("Punto 1");
            int number = 0;

            // Console.Write("Numero ingresado {0}\n",number);
            int resultadoPunto1 = number.Divide100By();

          
            Console.ReadLine();

            //Punto2
            Console.WriteLine("Punto 2 Dividamos");


            int resultadoPunto2 = Methods.Division();
          
            Console.ReadLine();



        }

    }
}
