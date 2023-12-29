using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Builderz.Models.Media
{
    [ContentType(DisplayName = "Image File",
            Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}
