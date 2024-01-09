using Builderz.Models.Blocks;
using Builderz.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Builderz.Components
{
    [TemplateDescriptor(AvailableWithoutTag = true)]
    public class RecentPostBlockComponent : BlockComponent<RecentPostBlock>
    {
        protected override IViewComponentResult InvokeComponent(RecentPostBlock currentBlock)
        { 
            return View(currentBlock);
        }
    }
}
