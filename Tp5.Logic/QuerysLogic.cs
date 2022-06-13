using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Commons;
using Tp5.Entities;

namespace Tp5.Logic
{
    public class QuerysLogic : BaseLogic
    {
        public List<Customers> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        public List<Products> GetProductsWithoutStock()
        {
            return _context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }
        public List<Products> GetProductsWithStockAndPriceMoreThan3()
        {
           return (from product in _context.Products
                   where product.UnitsInStock > 0
                    &&   product.UnitPrice > 3
                   select product).ToList();
        }
        public List<Customers> GetCustomersInWA()
        {
            return (from customers in _context.Customers
                    where customers.Region == "WA"
                    select customers).ToList();
        }

        public Products GetProductbyID(int id)
        {  
            return _context.Products.FirstOrDefault(p => p.ProductID == id);
        }

        public List<Orders> OrdersWaCustomers()
        {
            return (from o in _context.Orders
                    join c in _context.Customers on o.CustomerID equals c.CustomerID
                    where o.OrderDate > new DateTime(1997, 1, 1)
                    && c.Region == "WA"
                    select o)
                    .ToList();
        }
        
        public List<Customers> FirstThreeCustomersFromWA()
        {

            return _context.Customers.Take(3).ToList();
        }

        public List<Products> ProductsOrderedByName()
        {

            return _context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Products> ProductsOrderedByStock()
        {

            return (from p in _context.Products
                    orderby p.UnitsInStock descending
                    select p)
                    .ToList();
        }
        public Products ProductsFirstElement()
        {
            return _context.Products.First();
        }
     

    }
}
