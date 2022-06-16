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
        public bool Add(Shippers newShipper)

        {
           
            try
            {
                _context.Shippers.Add(newShipper);
                Methods.NullCheck(newShipper.CompanyName);
                _context.SaveChanges();
                return  true;
            }
            
            catch
            {
                 return  false;
            }
        }
        public bool Delete(int id)
        {
            
            var shipperToDelete = _context.Shippers.Find(id);
          

            try {
                Methods.NullCheck(shipperToDelete);
                _context.Shippers.Remove(shipperToDelete);
                _context.SaveChanges();
                return true;

            }
            //what do(System.Data.Entity.Infrastructure.DbUpdateException ex) 
           
            catch
            {
                return false;
            }
           
            
        }
        public  bool Update(Shippers shipper)
        {

          
            var shipperToUpdate = _context.Shippers.Find(shipper.ShipperID);
            
                try
                {
                Methods.NullCheck(shipperToUpdate);
                  
                    shipperToUpdate.CompanyName = shipper.CompanyName;
                    shipperToUpdate.Phone = shipper.Phone;

                    _context.SaveChanges();
                    return true;
                }
               
                catch
                {
               
                    return false;
                }
                
        }



     }

}

