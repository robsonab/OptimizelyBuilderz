using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Teaser",
                 GroupName = SiteGroupNames.Common,
                 Description = " Use this for rich text with heading, image and page link that will be reused in multiple places.")]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "SubTitle", Order = 20, GroupName = SystemTabNames.PageHeader)]
        public virtual string SubTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Body", Order = 20)]
        public virtual XhtmlString Body { get; set; }

        [Display(Name = "Image", Order = 30, GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(Name = "Link", Order = 40, GroupName = SystemTabNames.PageHeader)]
        public virtual PageReference Link { get; set; }
    }
}
