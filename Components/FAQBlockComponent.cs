using Builderz.Models.Blocks;
using Builderz.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Components
{
    [TemplateDescriptor(AvailableWithoutTag = true)]
    public class FAQBlockComponent : BlockComponent<FAQBlock>
    {
        protected override IViewComponentResult InvokeComponent(FAQBlock currentBlock)
        {
            var result = new FAQBlockViewModel
            {
                CurrentBlock = currentBlock
            };

            if (currentBlock.FAQItems != null && currentBlock.FAQItems.Any())
            {
                var half = (int)Math.Round((decimal)currentBlock.FAQItems.Count / 2, MidpointRounding.AwayFromZero);
                result.Col1 = currentBlock.FAQItems.Take(half).ToList();
                result.Col2 = currentBlock.FAQItems.Skip(half).ToList();
            }

            return View(result);
        }
    }
}
