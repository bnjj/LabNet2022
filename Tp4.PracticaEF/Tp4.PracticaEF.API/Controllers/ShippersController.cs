using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Tp4.PracticaEF.API.Models;
using Tp4.PracticaEF.Entities;
using Tp4.PracticaEF.Logic;

using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Tp4.PracticaEF.API.Controllers
{
    public class ShippersController : ApiController
    {

        readonly ShippersLogic shippersLogic = new ShippersLogic();
        // GET: Shippers
        [HttpGet]
        public IHttpActionResult Get() 
        {
            try
            {  
            ShippersLogic shippersLogic = new ShippersLogic();
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();
            return Ok(shippersView);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id) 
        {
           
            
            bool Deleted= shippersLogic.Delete(id);

            if (Deleted)
            { 
            return Ok("Se elimino el id ingresado");
            }
            else
            {
                return Content(HttpStatusCode.NotFound,"No se encontro el id,");
            }
            
         
        }

        [HttpPost]

        public IHttpActionResult Post([FromUri] ShippersView  shippersView)
        {
            
          
            if (!ModelState.IsValid)
            {
                return BadRequest("El Modelo no es valido.(Campo requerido vacio o formato incorrecto)");
            }
            else
            {

                try
                {

                    Shippers shippersEntity = new Shippers
                    {
                        
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    shippersLogic.Add(shippersEntity);
                   
                   return Ok(shippersEntity);
                }
                catch
                {
                  return BadRequest("No se pudo agregar");
                }
            }
        }

        [HttpPut]

        public IHttpActionResult Put([FromUri]ShippersView shippersView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("El Modelo no es valido.(Campo requerido vacio o formato incorrecto)");
            }
            else
            {
                try
                {

              
                    Shippers shippersEntity = new Shippers
                    {
                        ShipperID = shippersView.Id,
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    bool Updated =  shippersLogic.Update(shippersEntity);

                    if(Updated)
                    { 
                    return Ok(shippersEntity);
                    }
                    else 
                    {
                        return Content(HttpStatusCode.NotFound,"No se encontro el id,");
                    }

                }
                catch(Exception ex)
                {
                    return Content(HttpStatusCode.NotFound,ex.Message);
                }
            }
           
        }
   






      
        










    }

}
