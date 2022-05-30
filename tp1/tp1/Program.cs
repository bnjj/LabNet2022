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

        
            Menu.ShowMainMenu();
            while (input != exitButton)
            {

                UserOption();

                switch (input)
                {


                    case "1":

                        Menu.ShowTransportAddMenu();

                        while (input !=  goBackButton)
                        {
                            UserOption();
                            switch (input)
                            {

                                case "1":
                                  
                                    CheckIfTaxiCanbeAdded();
                                   break;

                                    
                                case "2":

                                    CheckIfBusCanBeAdded();
                                    break;

                                case "N":

                                    Menu.ShowMainMenu();
                                    break;
                                case "X":

                                    Menu.ShowExitMessage();
                                    return;
                                default:

                                    Menu.ShowTransportAddMenu();
                                    Menu.InvalidOption();

                                    break;
                            }
                        }
                        
                        break;


                        case "2":

                        PrintTransportList();

                        break;

                        case "8":

                        Menu.ShowListDeleteMenu();
                        
                        while(input != goBackButton)
                        {
                            UserOption();
                            switch (input)
                            {
                                case "1":
                                    
                                    DeleteAllVehicles();
                                    
                                    break;

                                case "N":
                                    Menu.ShowMainMenu();
                                    break;

                                default :

                                    Menu.ShowListDeleteMenu();
                                    Menu.InvalidOption();
                                    
                                    break;



                            }
                           
                        }
                        break;

                   


                    case "X":

                        Menu.ShowExitMessage();

                        break;

                    default:

                        Menu.ShowMainMenu();
                        Menu.InvalidOption();
                        break;


                }

            }







            void UserOption()
            {
                input = Console.ReadLine().ToUpper();

            }


            void DeleteAllVehicles()
            {
                Console.Clear();
                transports.Clear();
                taxiCount = 0;
                busCount = 0;
                Console.WriteLine("La lista fue borrada con Exito.");

                 input = goBackButton;
            }



            void AddVehicle(int Passenger,int count,string vehicle)
            {
                if(vehicle == "Taxi")
                {
                    taxiCount++;
                    transports.Add(new Taxi(Passenger));
                    Console.WriteLine("{0} agregado con exito.", vehicle);
                    Console.WriteLine("Van {0} {1}s ", taxiCount,vehicle);
                    Console.ReadLine();

                }
                else if (vehicle == "Bus")
                {
                    busCount++;
                    transports.Add(new Bus(Passenger));
                    Console.WriteLine("{0} agregado con exito.", vehicle);
                    Console.WriteLine("Van {0} {1} ", busCount, vehicle);
                    Console.ReadLine();

                }

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


            void CheckIfTaxiCanbeAdded()
            {
                if (taxiCount < maxTaxiAmount)
                {

                    while (taxiCount < maxTaxiAmount)
                    {

                        Menu.ShowNewTaxiMenu();
                        input = Console.ReadLine();
                        CatchTryParse = int.TryParse(input, out taxiPassengers);
                        if (CatchTryParse == true)
                        {
                            if (taxiPassengers >= 0 && taxiPassengers <= maxTaxiPassengersAmount && taxiCount < maxTaxiAmount)
                            {
                                AddVehicle(taxiPassengers, taxiCount, "Taxi");
                            }
                            else
                            {
                                Menu.TooMuchPassengersMessage();
                                Console.ReadLine();
                            }


                        }
                        else if (input.ToUpper() == goBackButton)
                        {

                            Menu.IncompleteListMessage(taxiCount, "Taxis");

                            break;
                        }
                        else
                        {
                            Menu.InvalidOption();
                            Console.ReadLine();
                        }

                    }
                }
                else
                {
                    Menu.TransportsAlreadyRegisteredMessage("Taxis");
                }
               
            }
            void CheckIfBusCanBeAdded()
            {
                if (busCount < maxBusAmount)
                {

                    while (busCount < maxBusAmount)
                    {

                        Menu.ShowNewBusMenu();
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
                                Menu.TooMuchPassengersMessage();
                                Console.ReadLine();
                            }


                        }
                        else if (input.ToUpper() == goBackButton)
                        {

                            Menu.IncompleteListMessage(busCount, "Omnibus");

                            break;
                        }
                        else
                        {
                            Menu.InvalidOption();
                            Console.ReadLine();
                        }

                    }
                }
                else
                {
                    Menu.TransportsAlreadyRegisteredMessage("Omnibus");
                }
            }
            





        }

     




    }
}
