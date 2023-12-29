using Builderz.Models.Blocks;
using Builderz.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Components
{
    [TemplateDescriptor(AvailableWithoutTag = true)]
    public class TeaserBlockComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewmodel);
        }
    }
}

