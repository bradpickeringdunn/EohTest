﻿using System.Web;
using System.Web.Mvc;

namespace EOHTest.Service.Crud
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}