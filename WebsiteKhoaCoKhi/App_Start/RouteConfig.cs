using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebsiteKhoaCoKhi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "News",
               url: "news/{metaTitle}",
               defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "WebsiteKhoaCoKhi.Controllers" }
           );

            routes.MapRoute(
              name: "AllNews",
              url: "{metaTitle}",
              defaults: new { controller = "News", action = "News", id = UrlParameter.Optional },
              namespaces: new[] { "WebsiteKhoaCoKhi.Controllers" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"WebsiteKhoaCoKhi.Controllers"}
            );
           
        }
    }
}
