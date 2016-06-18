using Handlebars.Rx.UI.Example.App.Services;
using System.Web.Mvc;

namespace Handlebars.Rx.UI.Example.App.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController(IPageService pageService)
        {
            _pageService = pageService;
        }

        public ActionResult Index()
        {
            return View(_pageService.Get());
        }

        protected readonly IPageService _pageService;
    }
}