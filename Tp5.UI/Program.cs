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

            Console.WriteLine("\n\n----------Inicio Punto 1 Clientes---------- \n");
            foreach(var c in customers)
            {
                Console.WriteLine(String.Format("ID :{0,-10} |  Empresa: {1,-40} | Encargado :{2,-20}|", c.CustomerID, c.CompanyName, c.ContactName));
              
        
            }
            Console.WriteLine("\n----------Fin Punto 1 Clientes---------- ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 2 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 2 Productos sin stock----------");
            var productsNoStock= querysLogic.GetProductsWithoutStock();
            foreach(var p in productsNoStock)
            {
                Console.WriteLine(String.Format(" ID :{0,-5} | Producto:{1,-40} | Stock:{2,-5}|",p.ProductID,p.ProductName,p.UnitsInStock));
              
            }

            Console.WriteLine("\n----------Fin Punto 2 Productos sin stock---------- ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 3 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 3 Productos con stock y precio mayor a 3----------");
            var productsInStock = querysLogic.GetProductsWithStockAndPriceMoreThan3();
            foreach(var p in productsInStock)
            {
                
                Console.WriteLine(String.Format(" ID :{0,-5} | Producto:{1,-40} |  Stock:{2,5}| Precio:{3,5}|", p.ProductID,p.ProductName,p.UnitsInStock,p.UnitPrice));
                
            }
            Console.WriteLine("\n----------Fin Punto 3 Productos con stock y precio mayor a 3---------- ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 4 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 4 Clientes en la region de WA----------");
            var customersWA = querysLogic.GetCustomersInWA();

            foreach (var c in customersWA)
            {
               
                Console.WriteLine(String.Format(" ID :{0,-5} | Empresa: {1,-40} | Region : {2,-5}|",c.CustomerID,c.CompanyName,c.Region));
              
            }
            Console.WriteLine("\n----------Fin Punto 4 Clientes en la region de WA----------  ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 5 ");
            Console.ReadLine();


            Console.WriteLine("\n\n---------- Inicio Punto 5 Producto x Id----------");
            var productById=querysLogic.GetProductbyID(789);

            bool IsNull =C.NullCheck(productById);
            if(IsNull==false)
            {
               
                Console.WriteLine(productById.ProductID + " " + productById.ProductName + " " + productById.UnitsInStock + " " + productById.UnitPrice);
            }
            Console.WriteLine("\n----------Fin Punto 5 Producto por ID----------");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 6 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 6 Customers en Mayus y minus----------");

            foreach (var c in customers)
            {
                Console.WriteLine(String.Format("|Minuscula :{0,-40}|",c.ContactName.ToLower()));
                Console.WriteLine(String.Format("|Mayuscula :{0,-40}|", c.ContactName.ToUpper()));
                
                
            }
            Console.WriteLine("\n----------Fin Punto 6 Customers en Mayus y Minus ---------- ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 7 ");
            Console.ReadLine();


            Console.WriteLine("\n\n---------- Inicio Punto 7  Join  Customers y Orders de la Región WA  fecha de orden sea mayor a 1 / 1 / 1997.----------");
            var ordersWaCustomers= querysLogic.OrdersWaCustomers();

            foreach(var o in ordersWaCustomers)
            {
               Console.WriteLine(String.Format("| Empresa :{0,-40}| Region :{1,-5}| Fecha : {2,-30} |", o.ShipName,o.ShipRegion,o.OrderDate));

            }
            Console.WriteLine("\nFin Punto 7 Ordenes de la region de WA luego del 1/1/1997  ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 8 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 8 Primeros 3 Customers por ID ----------");

            var topThreeCustomersWA = querysLogic.FirstThreeCustomersFromWA();

            
                foreach (var c in topThreeCustomersWA)
                {
                Console.WriteLine(String.Format("| ID :{0,-10}| Empresa :{1,-40}| Region : {2,-10} |", c.CustomerID,c.CompanyName,c.Region));
                
                }
                Console.WriteLine("\n----------Fin Punto 8 Primeros 3 Customers por ID  ----------");
                Console.WriteLine("Presione cualquier tecla para mostrar punto 9 ");
                Console.ReadLine();
            

            Console.WriteLine("\n\n---------- Inicio  Punto 9 Productos ordenados por nombre----------");

            var productsOrdered= querysLogic.ProductsOrderedByName();


            foreach (var p in productsOrdered)
            {
                Console.WriteLine(String.Format("| ID :{0,-10}| Producto :{1,-40}| Stock : {2,-5} | Precio : {3,-5}", p.ProductID, p.ProductName, p.UnitsInStock, p.UnitPrice));
             
            }
            Console.WriteLine("\n---------- Fin  Punto 9 Productos ordenados por nombre ----------");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 10 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio  Punto 10 Productos ordenados por stock---------- ");

            var productsOrderedByStock = querysLogic.ProductsOrderedByStock();

            foreach (var p in productsOrderedByStock)
            {
                Console.WriteLine(String.Format("| ID :{0,-10}| Producto :{1,-40}| Stock : {2,-5} | Precio : {3,-5}", p.ProductID, p.ProductName, p.UnitsInStock, p.UnitPrice));

            }
            Console.WriteLine("\n---------- Fin  Punto 10 Productos ordenados por stock---------- ");
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 11 ");
            Console.ReadLine();

            Console.WriteLine("\n\n---------- Inicio Punto 11 Categorias de productos asociados---------- ");
            var categories = querysLogic.GetCategories();
               foreach (var c in categories)
            {
                Console.WriteLine(String.Format("| Categoria : {0,-20}|",c.CategoryName));
            }

            Console.WriteLine("\n---------- Fin Punto 11 Categorias de productos asociados---------- ");

            Console.WriteLine("\n\n---------- Inicio Punto 12 primer elemento de lista----------");
            var productsFirst = querysLogic.ProductsFirstElement();


            Console.WriteLine(String.Format("| ID :{0,-10}| Producto :{1,-40}| Stock : {2,-5} | Precio : {3,-5}", productsFirst.ProductID, productsFirst.ProductName, productsFirst.UnitsInStock, productsFirst.UnitPrice));
            Console.ReadLine();

            Console.WriteLine("\n----------Fin Punto 12 Primer producto lista---------- ");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("\nPresione cualquier tecla para mostrar punto 13 ");
            //Query para devolver los customer con la cantidad de ordenes asociadas

            Console.WriteLine("\n\n---------- Inicio Punto 13 Customers y cantidad de Ordenes asociadas.----------");
            var customersAssociatedOrders = querysLogic.CustomersAssociatedOrders();

            foreach(var c in customersAssociatedOrders)
            {
                Console.WriteLine(String.Format("| ID: {0,-5}| Empresa : {1,-40}| Cantidad de Ordenes : {2,-5}",c.Id,c.Name,c.OrdersQuantity));
           
            }

            Console.WriteLine("\n\n---------- Fin Punto 13 Customers y cantidad de Ordenes asociadas.----------");
            
            Console.WriteLine("Fin del Programa");
            Console.ReadLine();







        }
    }
}
