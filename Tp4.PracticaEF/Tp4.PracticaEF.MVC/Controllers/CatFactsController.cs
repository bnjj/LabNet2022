using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Collections.Generic;
using Tp4.PracticaEF.MVC.Models;


namespace Tp4.PracticaEF.MVC.Controllers
{
    public class CatFactsController : Controller
    {

      

        public async Task<ActionResult> Index()
        {   
            var client = new HttpClient();
            var json=await client.GetStringAsync("https://catfact.ninja/facts?limit=20&max_length=140");
             
              Root catFacts = JsonConvert.DeserializeObject<Root>(json);
              
            return View("Index",catFacts.Data);

        }
      
    }
}