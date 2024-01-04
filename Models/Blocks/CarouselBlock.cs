using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Carousel", GroupName = SiteGroupNames.Common)]
    [CarouselImageUrl]
    public class CarouselBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Previous Text", Order = 10)]
        public virtual string PreviousText { get; set; }
        
        [CultureSpecific]
        [Display(Name = "Next Text", Order = 20)]
        public virtual string NextText { get; set; }

        [CultureSpecific]
        [Display(Name = "Slides", Order = 30)]
        [AllowedTypes(typeof(SlideBlock))]
        public virtual ContentArea  Slides{ get; set; }

        [CultureSpecific]
        [Display(Name = "Show Text Labels", Order = 25)]
        public virtual bool ShowTextLabels { get; set; }

    }
}
