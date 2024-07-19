using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Pages
{
    public abstract class SitePageData : PageData
    {

        [Display(Name = "Main content area",
                Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
                GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}
