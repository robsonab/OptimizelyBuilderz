using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Recent Posts")]
    public class RecentPostBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Title { get; set; }


        [CultureSpecific]
        [Display(Name = "Item", Order = 30)]
        public virtual IList<RecentPostItem> Items { get; set; }

    }

    [ContentType(DisplayName = "Recent item", AvailableInEditMode = false)]
    public class RecentPostItem : BlockData
    {

        [CultureSpecific]
        [Display(Name = "Title", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "User Name", Order = 20, GroupName = SystemTabNames.PageHeader)]
        public virtual string UserName { get; set; }

        [CultureSpecific]
        [Display(Name = "Place", Order = 30, GroupName = SystemTabNames.PageHeader)]
        public virtual string Place { get; set; }

        [Display(Name = "Image", Order = 40, GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}
