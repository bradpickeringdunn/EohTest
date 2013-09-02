using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EohTest.Service.Crud
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Dismiss Employee",
                routeTemplate: "api/Employment/DismissEmployee/employeeId"
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
