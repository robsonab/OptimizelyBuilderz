using Builderz.Models.Blocks;
using Builderz.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Components
{
    [TemplateDescriptor(AvailableWithoutTag = true)]
    public class SlideBlockComponent : BlockComponent<SlideBlock>
    {
        protected override IViewComponentResult InvokeComponent(SlideBlock currentBlock)
        {
            return View(currentBlock);
        }
    }
}
