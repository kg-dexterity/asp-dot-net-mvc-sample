﻿using System.Web;
using System.Web.Mvc;

namespace ASP_Dot_Net_MVC_Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
