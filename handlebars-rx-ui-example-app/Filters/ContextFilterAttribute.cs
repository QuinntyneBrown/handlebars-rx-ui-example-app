using Handlebars.Rx.UI.Example.App.Extensions;
using Handlebars.Rx.UI.Example.App.Services;
using System.Web.Mvc;
using static Handlebars.Rx.UI.Example.App.Infrastructure.Constants;

namespace Handlebars.Rx.UI.Example.App.Filters
{
    public class ContextFilterAttribute: ActionFilterAttribute
    {
        public ContextFilterAttribute()
        {
            _contextProvider = DependencyResolver.Current.GetService<IContextProvider>();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Context context = _contextProvider.Get();
            context.RouteName = filterContext.RouteData.GetRouteName();
            
            foreach (var item in filterContext.RouteData.Values)
            {
                if (item.Key == Slug)
                    context.Slug = (string)item.Value;
            }

            _contextProvider.Set(context);

            base.OnActionExecuting(filterContext);
        }

        protected readonly IContextProvider _contextProvider;
    }
}