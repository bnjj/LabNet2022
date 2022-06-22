﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tp4.PracticaEF.API
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Parameter defaults
                new string[] { "Tp4.PracticaEF.API.Controllers" }
            );
        }
    }
}
