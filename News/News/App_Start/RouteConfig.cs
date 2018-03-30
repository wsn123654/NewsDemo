﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace News
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Accounts", action = "Login", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
              "Default",
              "{controller}/{action}/{id}",
              new { controller = "Accounts", action = "Login", id = UrlParameter.Optional },
              new[] { "News.Controllers" }
            );

        }
    }
}
