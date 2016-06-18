using Handlebars.Rx.UI.Example.App.Filters;
using System.Web.Mvc;

namespace Handlebars.Rx.UI.Example.App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ContextFilterAttribute());
        }
    }
}
