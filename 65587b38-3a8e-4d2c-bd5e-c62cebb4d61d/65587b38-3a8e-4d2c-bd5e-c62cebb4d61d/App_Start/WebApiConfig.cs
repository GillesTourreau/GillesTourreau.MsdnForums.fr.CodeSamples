using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _65587b38_3a8e_4d2c_bd5e_c62cebb4d61d
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
