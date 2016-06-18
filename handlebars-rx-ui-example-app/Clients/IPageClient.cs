namespace Handlebars.Rx.UI.Example.App.Clients
{
    public interface IPageClient
    {
        dynamic GetArticlePage(string slug);
        dynamic GetVideoPage(string slug);
        dynamic GetGalleryPage(string slug);
        dynamic GetArticlesPage();
    }
}
