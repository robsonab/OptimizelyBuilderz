using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "FAQ Item",
                   GroupName = SiteGroupNames.Common)]
    public class FAQItemBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Header", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(Name = "Body", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Body { get; set; }
    }
}
