using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Index",
                "index.html",
                 new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
               "IDHtml", // id伪静态    
               "{controller}/{action}/{id}.html",// 带有参数的 URL    
               new { controller = "Home", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );
            routes.MapRoute(
               "ActionHtml", // id伪静态    
               "{controller}/{action}.html",// 带有参数的 URL    
               new { controller = "Home", action = "Index", id = UrlParameter.Optional }// 参数默认值    
            );
             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            ); 
        }
    }
}
