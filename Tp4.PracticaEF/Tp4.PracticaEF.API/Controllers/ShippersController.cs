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
            shippersLogic.Delete(id);

            return Ok("Se elimino el id ingresado");
        }

        [HttpPost]

        public IHttpActionResult Post([FromUri] ShippersView  shippersView)
        {
            
          
            if (!ModelState.IsValid)
            {
                return BadRequest("No se pudo agregar");
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

   






      
        










    }

}
