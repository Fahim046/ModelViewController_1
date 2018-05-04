﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAss_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "About",
                url: "Home/index/{id}",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Contacts",
                url: "Home/index/{id}",
                defaults: new { controller = "Home", action = "Contacts", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Projects",
                url: "Home/index/{id}",
                defaults: new { controller = "Home", action = "Projects", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "FeverCheck",
                url: "Home/index/{id}",
                defaults: new { controller = "Home", action = "FeverCheck", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "GuessingGame",
               url: "Home/index/{id}",
               defaults: new { controller = "Home", action = "GuessingGame", id = UrlParameter.Optional }
           );
        }
    }
}
