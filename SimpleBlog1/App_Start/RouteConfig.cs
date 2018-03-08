using SimpleBlog1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var namespaces = new[] { typeof(PostController).Namespace };

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "login" });
            routes.MapRoute("Home", "", new { controller = "Post", action = "Index" }, namespaces);
            
        }
    }
}
