using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Entities;
using Tp4.PracticaEF.Logic;

namespace Tp4.PracticaEF.UI
{
    public class UI
    {
      

       
    public static void InitializeMenu()
        {
            ShowMainMenu();
            var input = Console.ReadLine().ToString().ToUpper();
            while (input != "N")
            {

                switch (input)
                {
                    case "1":
                        ShowList(input);
                        break;
                    case "2":
                        ShowList(input);
                        break;
                    case "3":
                        InputHandling.ShippersAddMenu();
                        break;
                    case "4":
                       InputHandling.ShippersDeleteMenu();
                        break;
                    case "5":
                        InputHandling.ShippersUpdateMenu();
                        break;
                    case "X":
                        Console.Clear();
                        Console.WriteLine("Adios");

                        return;
                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida");
                        break;

                }

                Console.ReadLine();
                Console.Clear();
                ShowMainMenu();
                input = Console.ReadLine().ToString().ToUpper();
            }


        }
        public static void ShowMainMenu()
        {
            Console.WriteLine("BIENVENIDO POR FAVOR SELECCIONE UNA OPCION");
            Console.WriteLine("1 - Listar Territorios");
            Console.WriteLine("2 - Listar Shippers");
            Console.WriteLine("3 - Insert Shippers");
            Console.WriteLine("4 - Delete Shippers");
            Console.WriteLine("5 - Update Shippers\n");
            Console.WriteLine("X - Salir del Programa");
            Console.Write("Opcion : ");
        }
        public static void ShowList(string input)
        {
            if(input == "1")
            {
                TerritoriesLogic territoriesLogic = new TerritoriesLogic();

                Console.WriteLine("Descripcion ========================================= TerritoryID == RegionID");
                foreach (var territories in territoriesLogic.GetAll())
                {
                    Console.WriteLine($"|{territories.TerritoryDescription}|    | {territories.TerritoryID} |     | {territories.RegionID}|");
                }

            }
            else if(input == "2")
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine($"ID-Empresa --------- Telefono");
                foreach (var shippers in shippersLogic.GetAll())
                {
                   
                    Console.WriteLine($"-{shippers.ShipperID}-{shippers.CompanyName}-{shippers.Phone}-");
                }
            }

        }

      

    }
}
