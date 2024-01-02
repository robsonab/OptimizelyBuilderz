using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "FAQ",
                 GroupName = SiteGroupNames.Common)]
    public class FAQBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "SubTitle", Order = 20, GroupName = SystemTabNames.PageHeader)]
        public virtual string SubTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "FAQ Items", Order = 30)]
        public virtual  IList<FAQItemBlock> FAQItems { get; set; }
    }
}
