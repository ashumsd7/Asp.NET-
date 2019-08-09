using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Understand_model
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
              name: "",
              url: "",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );


         



           // routes.MapRoute(
           //    name: "Default",
           //    url: "{controller}",
           //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           //);


            routes.MapRoute(
               name: "",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );



           
        }
    }
}
