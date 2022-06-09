using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Commons;
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
            
            try
            {
                _context.Shippers.Add(newShipper);
                Methods.NullCheck(newShipper.CompanyName, "nullCheck");
                _context.SaveChanges();
            }
            
            catch(Exception ex)
            {
                Console.WriteLine("No se puede dejar vacio un campo requerido",ex);
            }
        }
        public void Delete(int id)
        {
            
            var shipperToDelete = _context.Shippers.Find(id);
          

            try {
                Methods.NullCheck(shipperToDelete,"idCheck");
                _context.Shippers.Remove(shipperToDelete);
                _context.SaveChanges();
                Console.WriteLine("Se borro el campo con exito");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Update(Shippers shipper)
        {


            var shipperToUpdate = _context.Shippers.Find(shipper.ShipperID);
            
                try
                {
                Methods.NullCheck(shipperToUpdate,"idCheck");
                shipperToUpdate.CompanyName = shipper.CompanyName;
                shipperToUpdate.Phone = shipper.Phone;
                    _context.SaveChanges();
                    Console.WriteLine("Se Actualizo el campo con exito");

                }
                catch(CustomException ex)
                {
                Console.WriteLine(ex.Message);
                }
                catch
                {
                Console.WriteLine("No se puede dejar vacio un campo requerido");
                }
                
        }



     }

}

