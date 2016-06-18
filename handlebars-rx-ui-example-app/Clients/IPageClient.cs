using Handlebars.Rx.UI.Example.App.Dtos;

namespace Handlebars.Rx.UI.Example.App.Clients
{
    public interface IPageClient
    {
        PageDto GetArticlePage(string slug);
        PageDto GetVideoPage(string slug);
        PageDto GetGalleryPage(string slug);
        PageDto GetArticlesPage();
    }
}
