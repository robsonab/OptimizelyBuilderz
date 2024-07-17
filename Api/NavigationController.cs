using Builderz.Business.ExtensionMethods;
using Builderz.Models.Pages;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationController : ControllerBase
    {
        private readonly IContentLoader _contentLoader;
        private readonly UrlResolver _urlResolver;
        
        
        public NavigationController(IContentLoader contentLoader, UrlResolver urlResolver)
        {
            _contentLoader = contentLoader;
            _urlResolver = urlResolver; 
        }

        [HttpGet]
        public IActionResult NavigationMenus()
        {
            var rootLink = ContentReference.RootPage;
            var home = _contentLoader.GetChildren<StartPage>(rootLink).FirstOrDefault();

            List<Menu> GetPages(ContentReference reference)
                    => _contentLoader.GetChildren<StandardPage>(reference)
                                     .FilterForDisplay()
                                     .ToList()
                                     .Select(p => new Menu
                                     {
                                         Name = p.Name,
                                         Url = _urlResolver.GetUrl(p.ContentLink),
                                         SubMenus = GetPages(p.ContentLink)
                                     }).ToList();

            var pages = GetPages(home.ContentLink);

            return new JsonResult(pages);
        }
                 

        private class Menu
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public List<Menu> SubMenus { get; set; }
        }
    }
}
