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
                Console.WriteLine("Por favor espere,procesando datos");
                TerritoriesLogic territoriesLogic = new TerritoriesLogic();
              
                Console.WriteLine("Descripcion ========================================= TerritoryID == RegionID");
                foreach (var territories in territoriesLogic.GetAll())
                {
                    Console.WriteLine($"|{territories.TerritoryDescription}|    | {territories.TerritoryID} |     | {territories.RegionID}|");
                }
                Console.WriteLine("\nPresione enter para continuar...");

            }
            else if(input == "2")
            {
                Console.WriteLine("Por favor espere,procesando datos");
                ShippersLogic shippersLogic = new ShippersLogic();
            
                foreach (var shippers in shippersLogic.GetAll())
                {
                    
                    Console.WriteLine($"ID - {shippers.ShipperID} - Empresa - {shippers.CompanyName} - Telefono - {shippers.Phone}");
                }
                Console.WriteLine("\nPresione enter para continuar...");
            }

        }

      

    }
}
