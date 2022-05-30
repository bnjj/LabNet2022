using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public  class Menu
    {
        


        public static void InvalidOption()
        {
            Console.WriteLine("\n Por favor seleccione una opcion valida ");
            Console.Write("Opcion:");
        }


        public static void ShowNewBusMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("N.Volver atras \n");
            Console.WriteLine("Cantidad de Pasajeros del Omnibus (0-100)");
        }
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Ingrese una opcion \n");
            Console.WriteLine("1.Ingresar vehiculos");
            Console.WriteLine("2.Visualizar vehiculos ");
            Console.WriteLine("8.Limpiar lista de  vehiculos ");
            Console.WriteLine("X.Salir del programa\n");

            Console.Write("Opcion:");

        }

        public static void ShowTransportAddMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Que vehiculo le gustaria ingresar \n");
            Console.WriteLine("1.Taxi");
            Console.WriteLine("2.Omnibus");
            Console.WriteLine("N.Volver atras");
            Console.WriteLine("X.Salir del programa\n");


            Console.Write("Opcion:");

        }

        public static void ShowNewTaxiMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("N.Volver atras \n");
            Console.WriteLine("Cantidad de Pasajeros del Taxi (0-4)\n");

            Console.Write("Opcion:");


        }

        public static void ShowListDeleteMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Esta seguro de eliminar lista?");
            Console.WriteLine("1.Borrar");
            Console.WriteLine("N.Volver Atras");

        }

        public static void ShowExitMessage()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Programa terminado presione una tecla para cerrar la consola...");
            Console.ReadLine();
        }

        public static void TransportsAlreadyRegisteredMessage(string vehicle)
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Todos los {0} estan ya registrados! Limpie la lista e intente nuevamente.", vehicle);
        }

        public static void IncompleteListMessage(int vehicleCount, string vehicle)
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("La carga de {1} fue interrumpida.Puede continuarla luego.Se registraron {0} {1} ", vehicleCount, vehicle);
        }

        public static void TooMuchPassengersMessage()
        {
            Console.WriteLine("Son muchos pasajeros para este vehiculo.");
        }
    }
}
