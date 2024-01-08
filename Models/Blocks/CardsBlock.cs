using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Cards",
                 GroupName = SiteGroupNames.Common)]
    public class CardsBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "Subtitle", Order = 20)]
        public virtual string SubTitle { get; set; }
                
        [Display(Name = "Items", Order = 20)]
        public virtual IList<CardItem> Items{ get; set; }

    }

    [ContentType(DisplayName = "Card Item",
                   GroupName = SiteGroupNames.Common)]
    public class CardItem : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10)]
        public virtual string Title { get; set; }
        
        [CultureSpecific]
        [Display(Name = "Body", Order = 20)]
        public virtual string Body { get; set; }

        [CultureSpecific]
        [Display(Name = "Image", Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}
