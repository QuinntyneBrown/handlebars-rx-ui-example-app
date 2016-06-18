using System.Web.Mvc;
using System.Web.Routing;
using Handlebars.Rx.UI.Example.App.Extensions;

namespace Handlebars.Rx.UI.Example.App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.Map(
                name: "Article",
                url: "story/{slug}",
                defaults: new { controller = "Default", action="Index" }
            );

            routes.Map(
                name: "Gallery",
                url: "gallery/{slug}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.Map(
                name: "Video",
                url: "video/{slug}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.Map(
                name: "Default",
                url: "",
                defaults: new { controller="Default", action = "Index" }
            );

            routes.Map(
                name: "NotFound",
                url: "{*url}",
                defaults: new { controller = "Default", action = "Index" }
            );

        }
    }
}

