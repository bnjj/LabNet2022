using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tp4.PracticaEF.Entities;
using Tp4.PracticaEF.Logic;
using Tp4.PracticaEF.MVC.Models;

namespace Tp4.PracticaEF.MVC.Controllers
{
    public class ShippersController : Controller
    {
        readonly ShippersLogic shippersLogic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()

        {
            ShippersLogic shippersLogic = new ShippersLogic();
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();
            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View("InsertUpdate",new ShippersView());
        }


        public ActionResult Delete(int id)
        {
            shippersLogic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            
            return View("InsertUpdate");
        }



       


        [HttpPost]
        public ActionResult InsertUpdate(ShippersView shippersView)
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
               
                return RedirectToAction("Index");
            }
            else
            {
                
            //Si hay error y se debe volver al sitio
                if (shippersView.Id <= 0)
                {
                   
                    return View("InsertUpdate");

                }
                 else
                {
                    return View("InsertUpdate",shippersView);
                }
            }
        }





    }



}