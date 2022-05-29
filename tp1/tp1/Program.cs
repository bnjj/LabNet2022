using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>();
            bool CatchTryParse;
            string input = null,
             exitButton = "X",
             goBackButton = "N";
            int taxiCount = 0;
            int taxiPassengers = 0;
            int busCount = 0;
            int busPassengers = 0;
            int maxTaxiAmount = 5;
            int maxBusAmount = 5;
            int maxTaxiPassengersAmount = 4;
            int maxBusPassengersAmount = 100;


            ShowMainMenu();
            while (input != exitButton)
            {

                UserOption();

                switch (input)
                {


                    case "1":
                        Console.Clear();
                        ShowTransportAddMenu();

                        while (input !=  goBackButton)
                        {
                            UserOption();
                            switch (input)
                            {

                                case "1":
                                  
                                  
                                   if (taxiCount < maxTaxiAmount)
                                   {
                                       
                                        while(taxiCount<maxTaxiAmount)
                                        {
                                            Console.Clear();
                                            ShowNewTaxiMenu();
                                            CatchTryParse = int.TryParse(Console.ReadLine(), out taxiPassengers);
                                            if(CatchTryParse == true )
                                            { 
                                                if (taxiPassengers <= maxTaxiPassengersAmount)
                                                {
                                                taxiCount++;
                                                Console.WriteLine("Taxi agregado con exito.");
                                                Console.WriteLine("Van {0} taxis ", taxiCount);
                                                Console.ReadLine();
                                                }
                                          
                                              
                                            }
                                            else if (CatchTryParse == false)
                                            {
                                                InvalidOption();
                                            }
                                        }
                                      
                                        


                                   }
                                   else
                                   {
                                        Console.Clear();
                                        TransportsAlreadyRegisteredMessage("Taxis");
                                      
                                   }
                                   break;

                                    
                                case "2":
                                    Console.Clear();
                                    if (busCount < maxBusAmount)
                                    {
                                        ShowNewBusMenu();
                                    }
                                    else
                                    {
                                        TransportsAlreadyRegisteredMessage("Omnibus");
                                    }
                                    break;


                                case "N": //REVISAR
                                    break;

                                default:
                                    Console.Clear();
                                    ShowTransportAddMenu();
                                    InvalidOption();

                                    break;

                                case "X":
                                    Console.Clear();
                                    ShowExitMessage();
                                    return;

                            }
                        }
                        break;


                    case "2":
                        PrintTransportList();


                        Console.WriteLine("X.Salir del programa");
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.Clear();
                        ShowListDeleteMenu();
                        
                        while(input != goBackButton)
                        {
                            UserOption();
                            switch (input)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("La lista fue borrada con Exito.");
                                    Console.ReadLine();
                                    input = goBackButton;
                                    break;

                                default :
                                    Console.Clear();
                                    ShowListDeleteMenu();
                                    InvalidOption();
                                    UserOption();
                                    break;



                            }
                           
                        }
                        break;

                    case "X":
                        Console.Clear();
                        ShowExitMessage();

                        break;
                    default:

                        Console.Clear();
                        ShowMainMenu();
                        InvalidOption();
                        break;


                }

            }


















                


            void PrintTransportList()
            {

                foreach (Transport item in transports)
                {

                    Console.WriteLine(item.Report());

                }

            }



            void UserOption()
            {
                input = Console.ReadLine().ToUpper();
               
            }
            void InvalidOption()
            {
                Console.WriteLine("\n Por favor seleccione una opcion valida ");
                Console.Write("Opcion:");
            }



            void ShowMainMenu()
            {
                Console.WriteLine("Menu Transporte ");
                Console.WriteLine("Ingrese una opcion ");
                Console.WriteLine("1.Ingresar vehiculos");
                Console.WriteLine("2.Visualizar vehiculos ");
                Console.WriteLine("8.Limpiar lista de  vehiculos ");
                Console.WriteLine("X.Salir del programa\n");

                Console.Write("Opcion:");

            }

            void ShowTransportAddMenu()
            {

                Console.WriteLine("Menu Transporte ");
                Console.WriteLine("Que vehiculo le gustaria ingresar ");
                Console.WriteLine("1.Taxi");
                Console.WriteLine("2.Omnibus");
                Console.WriteLine("N.Volver atras");
                Console.WriteLine("X.Salir del programa\n");


                Console.Write("Opcion:");

            }

            void ShowNewTaxiMenu()
            {
                Console.WriteLine("Menu Transporte ");
                Console.WriteLine("N.Volver atras");
                Console.WriteLine("Cantidad de Pasajeros del Taxi (0-4)\n");

                Console.Write("Opcion:");


            }
            void ShowNewBusMenu()
            {

                Console.WriteLine("Menu Transporte ");
                Console.WriteLine("Cantidad de Pasajeros del Omnibus (0-100)");
            }
            void ShowListDeleteMenu() 
            {
                Console.WriteLine("Esta seguro de eliminar lista?");
                Console.WriteLine("1.Borrar");
                Console.WriteLine("N.Volver Atras");
            
            }

            void ShowExitMessage()
            {
                Console.WriteLine("Menu Transporte ");
                Console.WriteLine("Programa terminado presione una tecla para cerrar la consola...");
                Console.ReadLine();
            }

            void TransportsAlreadyRegisteredMessage(string vehicle)
            {
                Console.WriteLine("Menu Transporte");
                Console.WriteLine("Todos los {0} estan ya registrados! Limpie la lista e intente nuevamente.",vehicle);
            }




        }

     




    }
}
