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
                _context.SaveChanges();
            }
            
            catch(Exception ex)
            {
                Console.WriteLine("No se pudo agregar porque hay un campo requerido que esta vacio.",ex);
            }
        }
        public void Delete(int id)
        {
            
            var shipperToDelete = _context.Shippers.Find(id);
          

            try { 
                _context.Shippers.Remove(shipperToDelete);
                _context.SaveChanges();
              
            }
            catch
            {
                    throw new CustomException("No se pudo encontrar un ID coincidente");
            }
            Console.WriteLine("Se borro el campo con exito");
        }
        public void Update(Shippers shipper)
        {


            var shipperToUpdate = _context.Shippers.Find(shipper.ShipperID);
            
            if (shipperToUpdate == null)
            {
                try
                {
                    throw new CustomException("No se pudo encontrar un ID coincidente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

               
            }
            else
            {
                try
                {
                    shipperToUpdate.CompanyName = shipper.CompanyName;
                    shipperToUpdate.Phone = shipper.Phone;
                    _context.SaveChanges();
                    Console.WriteLine("Se Actualizo el campo con exito");

                }
                catch(Exception ex)
                {
                    Console.WriteLine("No se puede enviar un campo requerido vacio.Reintente por favor ", ex);
                }
                
            }



        }

    }
}
