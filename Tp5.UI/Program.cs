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

            Console.WriteLine("Inicio Punto 1 Clientes \n");
            foreach(var c in customers)
            {
                Console.WriteLine(c.CustomerID + "  " + c.CompanyName+"  "+c.ContactName);
            }
            Console.WriteLine("\nFin Punto 1 Clientes ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 2 ");
            Console.ReadLine();

            Console.WriteLine("\nPunto 2 Productos sin stock");
            var productsNoStock= querysLogic.GetProductsWithoutStock();
            foreach(var p in productsNoStock)
            {
                Console.WriteLine(p.ProductID + " " + p.ProductName + " " + p.UnitsInStock);
            }

            Console.WriteLine("\nFin Punto 2 Productos sin stock ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 3 ");
            Console.ReadLine();

            var productsInStock = querysLogic.GetProductsWithStockAndPriceMoreThan3();
            foreach(var p in productsInStock)
            {
                Console.WriteLine(p.ProductID + " " + p.ProductName + " " + p.UnitsInStock + " " + p.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 3 Productos con stock y precio mayor a 3 ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 4 ");
            Console.ReadLine();

            var customersWA = querysLogic.GetCustomersInWA();

            foreach (var c in customersWA)
            {
                Console.WriteLine(c.CustomerID + "  " + c.CompanyName + "  " + c.Region);
            }
            Console.WriteLine("\nFin Punto 4 Clientes en la region de WA  ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 5 ");
            Console.ReadLine();

            var productById=querysLogic.GetProductbyID(789);

            bool IsNull =C.NullCheck(productById);
            if(IsNull==false)
            {
                Console.WriteLine(productById.ProductID + " " + productById.ProductName + " " + productById.UnitsInStock + " " + productById.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 5 Producto por ID");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 6 ");
            Console.ReadLine();

            foreach (var c in customers)
            {
                Console.WriteLine(c.ContactName.ToLower());
                 Console.WriteLine(c.ContactName.ToUpper
                     ());
                
            }
            Console.WriteLine("\nFin Punto 6 Clientes en Mayus y Minus  ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 7 ");
            Console.ReadLine();

            var ordersWaCustomers= querysLogic.OrdersWaCustomers();

            foreach(var o in ordersWaCustomers)
            {
               Console.WriteLine(o.ShipName+ "  "+o.ShipRegion+"  "+o.OrderDate);
            
            }
            Console.WriteLine("\nFin Punto 7 Ordenes de la region de WA luego del 1/1/1997  ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 8 ");
            Console.ReadLine();

            Console.WriteLine("Primeros 3 clientes ordenados por ID ");

            var topThreeCustomersWA = querysLogic.FirstThreeCustomersFromWA();

            
                foreach (var c in topThreeCustomersWA)
                {
                    Console.WriteLine(c.CustomerID + "  " + c.CompanyName + "  " + c.Region);
                }
                Console.WriteLine("\nFin Punto 8 Top 3 Clientes en la region de WA  ");
                Console.WriteLine("Presione cualquier tecla para mostrar punto 9 ");
                Console.ReadLine();
            

            Console.WriteLine("\nProductos ordenados por nombre");

            var productsOrdered= querysLogic.ProductsOrderedByName();


            foreach (var p in productsOrdered)
            {
                Console.WriteLine(p.ProductID + " " + p.ProductName + " " + p.UnitsInStock + " " + p.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 9 Productos ordenados   ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 10 ");
            Console.ReadLine();

            Console.WriteLine("Productos ordenados por stock");

            var productsOrderedByStock = querysLogic.ProductsOrderedByStock();

            foreach (var p in productsOrderedByStock)
            {
                Console.WriteLine("Stock:"+p.UnitsInStock +  " " + p.ProductName + " " + p.ProductID + " " + p.UnitPrice);
            }
            Console.WriteLine("\nFin Punto 10 Productos ordenados  por stock ");


            Console.WriteLine("Fin del Programa");


            Console.ReadLine();







        }
    }
}
