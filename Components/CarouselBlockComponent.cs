using Builderz.Models.Blocks;
using Builderz.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Components
{
    [TemplateDescriptor(AvailableWithoutTag = true)]
    public class CarouselBlockComponent : BlockComponent<CarouselBlock>
    {
        protected override IViewComponentResult InvokeComponent(CarouselBlock currentBlock)
        {
            ViewData.Add(RenderSettings.HasContainerElement, false);
            return View(currentBlock);
        }
    }
}
