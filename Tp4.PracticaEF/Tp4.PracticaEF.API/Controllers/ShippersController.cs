using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Tp4.PracticaEF.Entities;
using Tp4.PracticaEF.Logic;
using Tp4.PracticaEF.MVC.Models;
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

        
        public IHttpActionResult Delete(int id)
        {
            shippersLogic.Delete(id);

            return Ok();
        }

   






        [HttpPost]
        public IHttpActionResult InsertUpdate(ShippersView shippersView)
        {
            if (ModelState.IsValid)
            {


                if (shippersView.Id <= 0)
                {
                    Shippers shippersEntity = new Shippers
                    {
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    shippersLogic.Add(shippersEntity);


                }

                else
                {
                    Shippers shippersEntity = new Shippers
                    {
                        ShipperID = shippersView.Id,
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    shippersLogic.Update(shippersEntity);


                }
                return Ok();
            }
            else
            {


                if (shippersView.Id <= 0)
                {

                    return Ok();

                }
                else
                {
                    return Ok(shippersView);
                }
            }
        }










    }

}
