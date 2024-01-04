using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;
using Builderz.Models.Pages;
using Builderz.Models.ViewModels;

namespace Builderz.Controllers
{
    [TemplateDescriptor(Inherited = true,
                        TemplateTypeCategory = TemplateTypeCategories.MvcController,
                        Tags = new[] { RenderingTags.Preview, RenderingTags.Edit },
                        AvailableWithoutTag = false)]
    public class PreviewController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        protected readonly IContentLoader loader;
        public PreviewController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public IActionResult Index(IContent currentContent)
        {
            SitePageData startPage = loader.Get<SitePageData>(ContentReference.StartPage);
            PreviewPageViewModel viewmodel = new(startPage, currentContent);
            return View(viewmodel);
        }
    }
}
