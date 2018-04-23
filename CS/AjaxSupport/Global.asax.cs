// Developer Express Code Central Example:
// How to use the jQuery.ajax function with DevExpress MVC Extensions
// 
// This example demonstrates how you can use the jQuery.ajax function to load a
// GridView on a callback.
// Note that this feature has been implemented in the 12.1
// version, so it is not available in earlier versions. For older versions, you can
// use a solution demonstrated in the http://www.devexpress.com/scid=E2927 example.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4063

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AjaxSupport {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}