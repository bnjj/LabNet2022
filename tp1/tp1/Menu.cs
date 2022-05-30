using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static int  TaxiCount = 0;
        static int BusCount = 0;
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
            Console.WriteLine("Cantidad de Pasajeros del Omnibus (0-100)\n");

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
        public static void CheckIfTaxiCanbeAdded()
        {
            int taxiPassengers;
          
            if (TaxiCount < MaxTaxiAmount)
            {

                while (TaxiCount < MaxTaxiAmount)
                {

                    ShowNewTaxiMenu();
                    Input = Console.ReadLine();
                    InputIsAnInt = int.TryParse(Input, out taxiPassengers);
                    if (InputIsAnInt)
                    {
                        if (taxiPassengers >= 0 && taxiPassengers <= MaxTaxiPassengersAmount && TaxiCount < MaxTaxiAmount)
                        {

                             AddVehicle(taxiPassengers, TaxiCount, "Taxi");
                        }
                        else
                        {
                            TooMuchPassengersMessage();
                            Console.ReadLine();
                        }


                    }
                    else if (Input.ToUpper() == GoBackButton)
                    {

                        IncompleteListMessage(TaxiCount, "Taxis");

                        break;
                    }
                    else
                    {

                        Console.WriteLine("\n Por favor seleccione una opcion valida ");
                        Console.ReadLine();

                    }

                }
            }
            else
            {
                TransportsAlreadyRegisteredMessage("Taxis");
            }

        }

        static void  AddVehicle(int Passenger, int count, string vehicle)
        {
            if (vehicle == "Taxi")
            {
                TaxiCount++;
                TransportsList.Add(new Taxi(Passenger));
                Console.WriteLine("{0} agregado con exito.", vehicle);
                Console.WriteLine("Van {0} {1}s ", TaxiCount, vehicle);
                Console.ReadLine();

            }
            else if (vehicle == "Bus")
            {
                BusCount++;
                TransportsList.Add(new Bus(Passenger));
                Console.WriteLine("{0} agregado con exito.", vehicle);
                Console.WriteLine("Van {0} {1} ", BusCount, vehicle);
                Console.ReadLine();

            }

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
        public static void CheckIfBusCanBeAdded()
        {
            int busPassengers;
            if (BusCount < MaxBusAmount)
            {

                while (BusCount < MaxBusAmount)
                {

                   ShowNewBusMenu();
                    Input = Console.ReadLine();
                    InputIsAnInt = int.TryParse(Input, out busPassengers);
                    if (InputIsAnInt)
                    {
                        if (busPassengers >= 0 && busPassengers <= MaxBusPassengersAmount && BusCount < MaxBusAmount)
                        {
                            AddVehicle(busPassengers, BusCount, "Bus");
                        }
                        else
                        {
                           TooMuchPassengersMessage();
                            Console.ReadLine();
                        }


                    }
                    else if (Input.ToUpper() == GoBackButton)
                    {

                        IncompleteListMessage(BusCount, "Omnibus");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n Por favor seleccione una opcion valida ");
                        Console.ReadLine();

                    }

                }
            }
            else
            {
                TransportsAlreadyRegisteredMessage("Omnibus");
            }
        }
        public static void UserOption()
        {
            Input = Console.ReadLine().ToUpper();
        }


    }
}
