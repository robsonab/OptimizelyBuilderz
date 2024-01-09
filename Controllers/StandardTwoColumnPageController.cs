using Builderz.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Controllers
{
    public class StandardTwoColumnPageController : PageControllerBase<StandardTwoColumnPage>
    {
        public StandardTwoColumnPageController(IContentLoader loader) : base(loader)
        {
        }

        //[ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
        public IActionResult Index(StandardTwoColumnPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
