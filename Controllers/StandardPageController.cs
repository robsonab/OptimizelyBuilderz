using Builderz.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader loader) : base(loader)
        {
        }

        //[ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
