using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _78579a63_40cb_45a3_bb8a_67bc2eb7abbb
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
