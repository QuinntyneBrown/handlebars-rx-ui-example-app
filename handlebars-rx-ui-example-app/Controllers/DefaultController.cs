using Handlebars.Rx.UI.Example.App.Services;
using System.Web.Mvc;

namespace Handlebars.Rx.UI.Example.App.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController(IContextProvider contextProvider, IPageService pageService)
        {
            _pageService = pageService;
            _context = contextProvider.Get();
        }

        public ActionResult Index()
        {
            return View(_context.RouteName,_pageService.Get());
        }

        protected readonly IPageService _pageService;
        protected readonly Context _context;
    }
}