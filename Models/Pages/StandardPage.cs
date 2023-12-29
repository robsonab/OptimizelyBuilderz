using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Pages
{
    [ContentType(DisplayName = "Standard",
         GroupName = SiteGroupNames.Common,
         Description = "Use this page type unless you need a more specialized one.")]    
    public class StandardPage : SitePageData
    {
        [Display(Name = "Main content area",
           Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
           GroupName = SystemTabNames.Content, Order = 30)]        
        public virtual ContentArea MainContentArea { get; set; }
    }
}
