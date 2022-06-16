using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Entities;
using Tp4.PracticaEF.Logic;

namespace Tp4.PracticaEF.UI
{
    public class InputHandling
    {
        
        public static void ShippersAddMenu()
        {  
            ShippersLogic shippersLogic = new ShippersLogic();

            Console.WriteLine("Nombre de la empresa :");
            string companyName = Console.ReadLine();
            Console.WriteLine("Telefono de la empresa");
            string phone = Console.ReadLine();



            bool addSuccess= shippersLogic.Add(new Shippers
            {
                CompanyName = companyName,
                Phone = phone
            });

            UI.OperationState(addSuccess,"Agregar");

        }
        public static void ShippersDeleteMenu()
        {
            ShippersLogic shippersLogic = new ShippersLogic();

            Console.WriteLine("Ingrese el ID que le gustaria buscar y borrar");
            bool deleteSuccess=false;
                try
                { 
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor espere,procesando datos");
                deleteSuccess = shippersLogic.Delete(id);
                }
                catch
                {
                 Console.WriteLine("Error,Ingrese un ID ");
                }

                 UI.OperationState(deleteSuccess, "Borrar");
             
          
            

        }
        public static void ShippersUpdateMenu()
        {
            bool parseSuccess;


             Console.WriteLine("Ingrese El ID del Shipper a actualizar");
           
              parseSuccess = int.TryParse(Console.ReadLine(), out int shipperID);
            
            while (parseSuccess !=true)
            {
                Console.Clear();
                Console.WriteLine("Debe ingresar un Numero ID");
                Console.WriteLine("Ingrese El ID del Shipper a actualizar");

                parseSuccess = int.TryParse(Console.ReadLine(), out  shipperID);

            }


            Console.WriteLine("Ingrese nombre de empresa");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono (puede omitir este campo o rellenarlo luego)");
                var phone= Console.ReadLine();

            ShippersLogic shippersLogic = new ShippersLogic();
            Console.WriteLine("Por favor espere,procesando datos");

            bool updateSuccess= shippersLogic.Update(new Shippers
            { 
                ShipperID = shipperID,
                CompanyName = companyName,
                Phone = phone
            });

            UI.OperationState(updateSuccess,"Actualizar");
        }
    }
}
