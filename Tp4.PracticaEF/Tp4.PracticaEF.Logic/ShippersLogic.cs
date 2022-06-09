using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Data;
using Tp4.PracticaEF.Entities;


namespace Tp4.PracticaEF.Logic
{
    public class ShippersLogic : BaseLogic
    {
      
  

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
        public void Add(Shippers newShipper)
        {
            _context.Shippers.Add(newShipper);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete(int id)
        {
            
            var shipperToDelete = _context.Shippers.Find(id);
            try { 
            _context.Shippers.Remove(shipperToDelete);
            _context.SaveChanges();
            }
            catch(Exception ex)
            {
            Console.WriteLine(ex.Message);
            
            }

        }
        public void Update(Shippers  shipper)
        {
          
          
               var shipperToUpdate = _context.Shippers.Find(shipper.ShipperID);
             if(shipperToUpdate != null) 
            { 
            
                shipperToUpdate.CompanyName = shipper.CompanyName;
                shipperToUpdate.Phone = shipper.Phone;

                _context.SaveChanges();
            }
            else 
            {
                Console.WriteLine("No se encontro el ID ingresado!");
            }


        }

    }
}
