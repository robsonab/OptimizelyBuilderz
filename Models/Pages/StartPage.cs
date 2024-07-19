using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace Builderz.Models.Pages
{
    [ContentType(DisplayName = "Start",
                  GroupName = SiteGroupNames.Specialized, Order = 10,
                  // your code will have a random GUID here
                  Description = "The home page for a website with an area for blocks and partial pages.")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading", 
                 Description = "If the Heading is not set, the page falls back to showing the Name.",
        GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
                Description = "The main body uses the XHTML-editor so you can insert, for example text, images, and tables.",
                GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }
        
    }
}
