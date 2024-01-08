using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Slide", GroupName = SiteGroupNames.Specialized)]
    public class SlideBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "SubTitle", Order = 20)]
        public virtual string SubTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Link", Order = 30)]
        public virtual PageReference Link { get; set; }


        [CultureSpecific]
        [Display(Name = "Image", Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}
