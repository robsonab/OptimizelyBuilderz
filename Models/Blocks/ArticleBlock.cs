using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Blocks
{
    [ContentType(DisplayName = "Article",
                 GroupName = SiteGroupNames.Common)]
    public class ArticleBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "Image", Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
           Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content, Order = 30)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
