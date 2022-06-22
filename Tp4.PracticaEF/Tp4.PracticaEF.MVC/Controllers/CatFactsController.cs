using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Tp4.PracticaEF.MVC.Models;


namespace Tp4.PracticaEF.MVC.Controllers
{
    public class CatFactsController : Controller
    {

      

        public async Task<ActionResult> Index()
        {   
            var client = new HttpClient();
            var json=await client.GetStringAsync("https://catfact.ninja/breeds?limit=20&max_length=140");
             
              Root catBreeds = JsonConvert.DeserializeObject<Root>(json);
              
            return View("Index",catBreeds.Data);

        }
      
    }
}