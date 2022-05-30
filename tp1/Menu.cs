using System;
using System.Collections.Generic;

namespace tp1
{
    public  class Menu
    {
        private static List<Transport> _transportsList = new List<Transport>();
        private const string _exitButton = "X";
        private const string _goBackButton = "N";
        private const int _maxTaxiAmount = 5;
        private const int _maxBusAmount = 5;
        private const int _maxTaxiPassengersAmount = 4;
        private const int _maxBusPassengersAmount = 100;
        private static bool _inputIsAnInt=false;
        private static string _input = null;
      
       

        public static int MaxTaxiAmount => _maxTaxiAmount;

        public static int MaxBusAmount => _maxBusAmount;

        public static int MaxTaxiPassengersAmount => _maxTaxiPassengersAmount;

        public static int MaxBusPassengersAmount => _maxBusPassengersAmount;

        public static string GoBackButton => _goBackButton;

        public static string ExitButton => _exitButton;

        public static bool InputIsAnInt { get => _inputIsAnInt; set => _inputIsAnInt = value; }

        public static string Input { get => _input; set => _input = value; }
    
        public static List<Transport> TransportsList { get => _transportsList; set => _transportsList = value; }

        public static int  TaxiCount = 0;
        public static int BusCount = 0;
       

        
        // MANEJO DE LISTA AGREGAR ,BORRAR ,MOSTRAR
        static void  AddVehicle(int Passenger, int count, string vehicle)
        {
            if (vehicle == "Taxi")
            {
                TaxiCount++;
                TransportsList.Add(new Taxi(Passenger));
                Console.WriteLine("{0} agregado con exito.", vehicle);
                Console.WriteLine("Hay {0} {1}s en lista", TaxiCount, vehicle);
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadLine();

            }
            else if (vehicle == "Bus")
            {
                vehicle="Omnibus";
                BusCount++;
                TransportsList.Add(new Bus(Passenger));
                Console.WriteLine("{0} agregado con exito.", vehicle);
                Console.WriteLine("Hay {0} {1} en lista", BusCount, vehicle);
                Console.ReadLine();

            }

        }
        public static void DeleteAllVehicles()
        {
            Console.Clear();
            TransportsList.Clear();
            TaxiCount = 0;
            BusCount = 0;
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("La lista fue borrada con Exito.");

            Input = GoBackButton;
        }
        public static void PrintTransportList()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");

            foreach (Transport item in TransportsList)
                    
                {

                Console.WriteLine(item.Report());

            }
            Console.WriteLine("\nPresione cualquier tecla para volver atras...");
            Console.WriteLine("\nX.Salir del Programa");

        }

     
        // INPUT PARA MENU
        public static void UserOption()
        {
            Input = Console.ReadLine().ToUpper();
        }

     

        //MENU OPCIONES
        public static void ShowNewVehicleMenu(int MaxVehiclePassengersAmount,string vehicle)
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("N.Volver atras \n");
            Console.WriteLine("Cantidad de Pasajeros del {0} (0-{1})\n",vehicle,MaxVehiclePassengersAmount);

            Console.Write("Opcion:");
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

     

        public static void ShowListDeleteMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Esta seguro de eliminar lista?");
            Console.WriteLine("1.Borrar");
            Console.WriteLine("N.Volver Atras");

        }
        // MENSAJES PARA EL USUARIO
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
            if(vehicle =="Bus")
            {
                vehicle="Omnibus";
            }
            if(vehicle =="Taxi")
            {
               vehicle="Taxis";
            }
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("Todos los {0} estan ya registrados! \nSi desea cargar nuevos datos borre la lista e intente nuevamente.", vehicle);
        }

        public static void IncompleteListMessage(int vehicleCount, string vehicle)
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("La carga de {1} fue interrumpida.Puede continuarla luego.Se registraron {0} {1} ", vehicleCount, vehicle);
        }
        public static void CompleteListMessage(string vehicle)
        {
            Console.Clear();
            Console.WriteLine("Menu Transporte \n");
            Console.WriteLine("La carga de {0} fue completada.Muchas gracias! ", vehicle);
        }

        public static void TooMuchPassengersMessage()
        {
            Console.WriteLine("Son muchos pasajeros para este vehiculo.");
        }
        public static void InvalidOptionMessage()
        {
            Console.WriteLine("\n Por favor seleccione una opcion valida ");
            Console.Write("Opcion:");
        }
        
        // Logica para verificar si podemos agregar un vehiculo
        public static void CheckIfVehicleCanBeAdded(int VehicleCount,string vehicle)
        {
            int passengers;
            int maxPassengersAmount=0;
            int maxVehicleAmount=0;
            if( vehicle=="Taxi")
            {
                maxPassengersAmount=Menu.MaxTaxiPassengersAmount;
                maxVehicleAmount=Menu.MaxTaxiAmount;
            }
            if(vehicle=="Bus")
            {
                maxPassengersAmount=Menu.MaxBusPassengersAmount; 
                maxVehicleAmount=Menu.MaxBusAmount;
            }
           if(VehicleCount<maxVehicleAmount)
            { 
                while(VehicleCount<maxVehicleAmount)
                { 

                    ShowNewVehicleMenu(maxPassengersAmount,vehicle);
                    Input = Console.ReadLine();
                    InputIsAnInt = int.TryParse(Input, out passengers);
                     if (InputIsAnInt)
                     {
                        if (passengers >= 0 && passengers <= maxPassengersAmount && VehicleCount < maxVehicleAmount)
                        {
                             VehicleCount++;
                             AddVehicle(passengers, VehicleCount,vehicle);
                        }
                        else if(passengers > maxPassengersAmount )
                        {
                            TooMuchPassengersMessage();
                            Console.ReadLine();
                        }
                           if(passengers < 0)
                            {
                            Console.WriteLine("Pasajeros negativos??? Imposible");
                                 Console.ReadLine();
                            }

                     }
                     else if (Input.ToUpper() == GoBackButton)
                     {

                        IncompleteListMessage(VehicleCount,vehicle);

                        break;
                     }
                     else
                     {

                        Console.WriteLine("\n Por favor seleccione una opcion valida ");
                        Console.ReadLine();

                     }
                }
                if(Input.ToUpper() != GoBackButton)
                { 
                CompleteListMessage(vehicle);
                }
            }
             else
            {
                TransportsAlreadyRegisteredMessage(vehicle);
            }
        }
    }





 }
    

