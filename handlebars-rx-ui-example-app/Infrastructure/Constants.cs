using System;

namespace Handlebars.Rx.UI.Example.App.Infrastructure
{
    public static class Constants
    {
        public static readonly Version Version = typeof(Constants).Assembly.GetName().Version;
        public const string RouteName = "routeName";
        public const string Slug = "slug";
    }
}