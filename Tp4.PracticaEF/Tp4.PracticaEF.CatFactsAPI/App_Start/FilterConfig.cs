﻿using System.Web;
using System.Web.Mvc;

namespace Tp4.PracticaEF.CatFactsAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}