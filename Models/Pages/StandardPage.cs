using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Pages
{
    [ContentType(DisplayName = "Standard",
         GroupName = SiteGroupNames.Common,
         Description = "Use this page type unless you need a more specialized one.")]    
    public class StandardPage : SitePageData
    {
        
    }
}
