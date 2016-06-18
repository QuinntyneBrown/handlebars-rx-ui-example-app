using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlebars.Rx.UI.Example.App.Services
{
    public class ContextProvider: IContextProvider
    {
        public Context Get()
        {
            return (HttpContext.Current.Items["Context"] ??
                (HttpContext.Current.Items["Context"] =
                new Context())) as Context;
        }

        public void Set(Context context)
        {
            HttpContext.Current.Items["Context"] = context;
        }
    }
}