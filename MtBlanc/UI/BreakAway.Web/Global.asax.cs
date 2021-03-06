﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITCloud.Web.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace BreakAway.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        static MvcApplication()
        {
            BreakAwayApplicationStarter starter = new BreakAwayApplicationStarter();
            starter.Start();
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.DiscoverMvcControllerRoutes();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}