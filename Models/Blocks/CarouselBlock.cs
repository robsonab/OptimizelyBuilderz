using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Carousel", GroupName = SiteGroupNames.Common)]
    public class CarouselBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Previous Text", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string PreviousText { get; set; }
        
        [CultureSpecific]
        [Display(Name = "Next Text", Order = 20, GroupName = SystemTabNames.PageHeader)]
        public virtual string NextText { get; set; }

        [CultureSpecific]
        [Display(Name = "Slides", Order = 30)]
        [AllowedTypes(typeof(SlideBlock))]
        public virtual ContentArea  Slides{ get; set; }

    }
}
