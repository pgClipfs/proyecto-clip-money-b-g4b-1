using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute("http://localhost:4200", headers: "*", methods: "*");
            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.EnableCors(cors);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                   //  defaults: new { id = RouteParameter.Optional }
                   defaults: null,
           constraints: new { id = @"^\d+$" } // Only integers 
            );

         
               config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}"
            );
        }
    }
}
