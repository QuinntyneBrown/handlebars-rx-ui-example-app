using System.Collections.Generic;

namespace Handlebars.Rx.UI.Example.App.Services
{
    public interface IContextProvider
    {
        Context Get();
        void Set(Context context);
    }
}
