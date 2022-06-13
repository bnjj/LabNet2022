using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Commons;
using Tp5.Logic;

namespace Tp5.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Presione cualquier tecla para mostrar punto 1 ");
            Console.ReadLine();

            QuerysLogic querysLogic = new QuerysLogic();
            var customers= querysLogic.GetCustomers();

            Console.WriteLine("Inicio Punto 1 Clientes ");
            foreach(var c in customers)
            {
                Console.WriteLine(c.CustomerID + "  " + c.CompanyName+"  "+c.ContactName);
            }
            Console.WriteLine("\nFin Punto 1 Clientes ");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 2 ");
            Console.ReadLine();

            Console.WriteLine("Punto 2 Productos sin stock");
            var productsNoStock= querysLogic.GetProductsWithoutStock();
            foreach(var p in productsNoStock)
            {
                Console.WriteLine(p.ProductID + " " + p.ProductName + " " + p.UnitsInStock);
            }

            Console.WriteLine("\nFin Punto 2 Productos sin stock ");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 3 ");
            Console.ReadLine();

            var productsInStock = querysLogic.GetProductsWithStockAndPriceMoreThan3();
            foreach(var p in productsInStock)
            {
                Console.WriteLine(p.ProductID + " " + p.ProductName + " " + p.UnitsInStock + " " + p.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 3 Productos con stock y precio mayor a 3 ");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 4 ");
            Console.ReadLine();

            var customersWA = querysLogic.GetCustomersInWA();

            foreach (var c in customersWA)
            {
                Console.WriteLine(c.CustomerID + "  " + c.CompanyName + "  " + c.Region);
            }
            Console.WriteLine("\nFin Punto 4 Clientes en la region de WA  ");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 5 ");
            Console.ReadLine();

            var productById=querysLogic.GetProductbyID(789);

            bool IsNull =C.NullCheck(productById);
            if(IsNull==false)
            {
                Console.WriteLine(productById.ProductID + " " + productById.ProductName + " " + productById.UnitsInStock + " " + productById.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 5 Producto por ID");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 6 ");
            Console.ReadLine();

            foreach (var c in customers)
            {
                Console.WriteLine(c.ContactName.ToLower());
                 Console.WriteLine(c.ContactName.ToUpper
                     ());
                
            }
            Console.WriteLine("\nFin Punto 6 Clientes en Mayus y Minus  ");
            Console.WriteLine("Presione cualquier tecla para mostrar punto 7 ");
            Console.ReadLine();

            var ordersWaCustomers= querysLogic.OrdersWaCustomers();

            foreach(var o in ordersWaCustomers)
            {
               Console.WriteLine(o.ShipName+ "  "+o.ShipRegion+"  "+o.OrderDate);
            
            }
            Console.ReadLine();












            Console.ReadLine();







        }
    }
}
