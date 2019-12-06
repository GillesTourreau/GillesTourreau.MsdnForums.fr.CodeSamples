using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _6b17da72_a903_4573_b738_ba731fb761aa
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
