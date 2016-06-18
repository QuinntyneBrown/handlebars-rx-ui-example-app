using Handlebars.Rx.UI.Example.App.Models;
using Handlebars.Rx.UI.Example.App.Clients;

namespace Handlebars.Rx.UI.Example.App.Services
{
    public class PageService : IPageService
    {
        public PageService(IContextProvider contextProvider, IPageClient pageClient)
        {
            _context = contextProvider.Get();
            _pageClient = pageClient;
        }

        public PageViewModel Get()
        {            
            switch (_context.RouteName)
            {
                case "Article":
                    return GetArticlePage(_context.Slug);

                case "Gallery":
                    return GetGalleryPage(_context.Slug);

                case "Video":
                    return GetVideoPage(_context.Slug);

                case "Default":
                    return GetArticlesPage();

                case "NotFound":
                    return GetNotFoundPage();
            }
            return new PageViewModel();
        }

        public PageViewModel GetArticlePage(string slug)
        {
            var response = _pageClient.GetArticlePage(slug);

            return new PageViewModel("Article");
        }

        public PageViewModel GetArticlesPage()
        {
            var page = new PageViewModel("Articles");

            var response = _pageClient.GetArticlesPage();

            page.Fragments.Add(new FragmentViewModel());

            return page;
        }

        public PageViewModel GetGalleryPage(string slug)
        {
            var response = _pageClient.GetGalleryPage(slug);

            return new PageViewModel("Gallery");
        }

        public PageViewModel GetVideoPage(string slug)
        {
            var response = _pageClient.GetVideoPage(slug);

            return new PageViewModel("Video");
        }

        public PageViewModel GetNotFoundPage()
        {
            return new PageViewModel("Not Found");
        }

        protected readonly Context _context;
        protected readonly IPageClient _pageClient;
    }
}