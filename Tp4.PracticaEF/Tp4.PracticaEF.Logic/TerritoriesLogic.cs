using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.PracticaEF.Data;
using Tp4.PracticaEF.Entities;

namespace Tp4.PracticaEF.Logic
{
    public class TerritoriesLogic : BaseLogic ,IABMLogic<Territories>
    {
       
   
        public TerritoriesLogic()
        {
        
        }
       
        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }
        public void Add(Territories newTerritory)
        {
            _context.Territories.Add(newTerritory);
            
            _context.SaveChanges();
        }
        public void Delete(int id)
        {   
            //Key de Territories es varchar 
             var TerritoryToDelete = _context.Territories.Find(id.ToString());
             _context.Territories.Remove(TerritoryToDelete);
             _context.SaveChanges();
        }
        public void Update(Territories territory)
        {
            var territoryToUpdate = _context.Territories.Find(territory.TerritoryID);

            territoryToUpdate.TerritoryDescription= territory.TerritoryDescription;
            territoryToUpdate.RegionID = territory.RegionID;

            _context.SaveChanges();
        }

    }
}
