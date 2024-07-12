using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Pages
{
    [ContentType(DisplayName = "Standard Two Column",
         GroupName = SiteGroupNames.Common,
         GUID = "d9e12581-a61d-4f8c-8f50-93f48fb352b3",
         Description = "Standard page with two columns")]
    public class StandardTwoColumnPage : StandardPage
    {
        [Display(Name = "Side content area",
          Description = "The side content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
          GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ContentArea SideContentArea { get; set; }
    }
}
