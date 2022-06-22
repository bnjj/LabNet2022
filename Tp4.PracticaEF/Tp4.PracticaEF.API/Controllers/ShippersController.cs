using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public IHttpActionResult Get() //funciona

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

        [HttpDelete]
        public IHttpActionResult Delete(int id) //funciona
        {
            if (id < 0)
            {
                return BadRequest("Id negativo ");
                
            }
           
            bool Deleted= shippersLogic.Delete(id);

            if (Deleted)
            { 
            return Ok("Se elimino el id ingresado");
            }
            else
            {
                return BadRequest("Id no encontrado");
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
                        return BadRequest("No se encontro el Id");
                    }

                }
                catch
                {
                    return BadRequest("Hubo un problema en la ejecucion de la request");
                }
            }
           
        }
   






      
        










    }

}
