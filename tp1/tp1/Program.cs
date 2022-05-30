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
                                           
                                            ShowNewTaxiMenu();
                                            input=Console.ReadLine();
                                            CatchTryParse = int.TryParse(input, out taxiPassengers);
                                            if(CatchTryParse == true )
                                            { 
                                                if (taxiPassengers >= 0 && taxiPassengers <= maxTaxiPassengersAmount && taxiCount < maxTaxiAmount)
                                                {
                                                    AddVehicle(taxiPassengers,taxiCount,"Taxi");
                                                }
                                                else
                                                {
                                                    TooMuchPassengersMessage();
                                                    Console.ReadLine();
                                                }
                                          
                                              
                                            }
                                            else if( input.ToUpper() == "M")
                                            {
                                                
                                                IncompleteListMessage(taxiCount,"Taxis");
                                                Console.ReadLine();
                                                break;
                                            }
                                            else
                                            {
                                                InvalidOption();
                                                Console.ReadLine();    
                                            }

                                        }
                                   }
                                   else
                                   {
                                        TransportsAlreadyRegisteredMessage("Taxis");                                      
                                   }
                                   break;

                                    
                                case "2":

                                    if (busCount < maxBusAmount)
                                    {

                                        while (busCount < maxBusAmount)
                                        {

                                            ShowNewBusMenu();
                                            input = Console.ReadLine();
                                            CatchTryParse = int.TryParse(input, out busPassengers);
                                            if (CatchTryParse == true)
                                            {
                                                if (busPassengers >= 0 && busPassengers <= maxBusPassengersAmount && busCount < maxBusAmount)
                                                {
                                                    AddVehicle(busPassengers, busCount, "Bus");
                                                }
                                                else
                                                {
                                                    TooMuchPassengersMessage();
                                                    Console.ReadLine();
                                                }


                                            }
                                            else if (input.ToUpper() == "M")
                                            {

                                                IncompleteListMessage(busCount, "Omnibus");
                                                Console.ReadLine();
                                                break;
                                            }
                                            else
                                            {
                                                InvalidOption();
                                                Console.ReadLine();
                                            }

                                        }
                                    }
                                    else
                                    {
                                        TransportsAlreadyRegisteredMessage("Omnibus");
                                    }
                                    break;




                                default:
                                    
                                    ShowTransportAddMenu();
                                    InvalidOption();

                                    break;

                                case "N":

                                   
                                    break;
                                case "X":
                                   
                                    ShowExitMessage();
                                    return;

                            }
                        }
                        break;


                    case "2":

                        PrintTransportList();

                        break;

                    case "8":
                        
                        ShowListDeleteMenu();
                        
                        while(input != goBackButton)
                        {
                            UserOption();
                            switch (input)
                            {
                                case "1":
                                    
                                    DeleteAllVehicles();
                                    
                                    break;

                                default :
                                    
                                    ShowListDeleteMenu();
                                    InvalidOption();
                                    
                                    break;



                            }
                           
                        }
                        break;

                    case "X":
                      
                        ShowExitMessage();

                        break;
                    default:

                        
                        ShowMainMenu();
                        InvalidOption();
                        break;


                }

            }














            void AddVehicle(int Passenger,int count,string vehicle)
            {
                if(vehicle == "Taxi")
                {
                    taxiCount++;
                    transports.Add(new Taxi(Passenger));
                    Console.WriteLine("{0} agregado con exito.", vehicle);
                    Console.WriteLine("Van {0} {1} ", taxiCount,vehicle);
                    Console.ReadLine();

                }
                else if (vehicle == "Bus")
                {
                    busCount++;
                    transports.Add(new Bus(Passenger));
                    Console.WriteLine("{0} agregado con exito.", vehicle);
                    Console.WriteLine("Van {0} {1}s ", busCount, vehicle);
                    Console.ReadLine();

                }

            }



            void DeleteAllVehicles()
            {
                Console.Clear();
                transports.Clear();
                Console.WriteLine("La lista fue borrada con Exito.");

                input = goBackButton;
            }


            void PrintTransportList()
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                foreach (Transport item in transports)
                {

                    Console.WriteLine(item.Report());

                }
                Console.WriteLine("\nPresione cualquier tecla para volver atras...");
                Console.WriteLine("\nX.Salir del Programa");

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
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("Ingrese una opcion \n");
                Console.WriteLine("1.Ingresar vehiculos");
                Console.WriteLine("2.Visualizar vehiculos ");
                Console.WriteLine("8.Limpiar lista de  vehiculos ");
                Console.WriteLine("X.Salir del programa\n");

                Console.Write("Opcion:");

            }

            void ShowTransportAddMenu()
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

            void ShowNewTaxiMenu()
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("M.Volver atras \n");
                Console.WriteLine("Cantidad de Pasajeros del Taxi (0-4)\n");

                Console.Write("Opcion:");


            }
            void ShowNewBusMenu()
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("Cantidad de Pasajeros del Omnibus (0-100)");
            }
            void ShowListDeleteMenu() 
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("Esta seguro de eliminar lista?");
                Console.WriteLine("1.Borrar");
                Console.WriteLine("N.Volver Atras");
            
            }

            void ShowExitMessage()
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("Programa terminado presione una tecla para cerrar la consola...");
                Console.ReadLine();
            }

            void TransportsAlreadyRegisteredMessage(string vehicle)
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("Todos los {0} estan ya registrados! Limpie la lista e intente nuevamente.",vehicle);
            }

            void IncompleteListMessage(int vehicleCount,string vehicle)
            {
                Console.Clear();
                Console.WriteLine("Menu Transporte \n");
                Console.WriteLine("La carga de {1} fue interrumpida.Puede continuarla luego.Se registraron {0} {1} ", vehicleCount,vehicle);
            }

            void TooMuchPassengersMessage()
            {   
                Console.WriteLine("Son muchos pasajeros para este vehiculo.");
            }


        }

     




    }
}
