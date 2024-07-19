using Builderz.Models.Blocks;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using Builderz.Business.ExtensionMethods;
using SixLabors.ImageSharp;

namespace Builderz.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselController : ControllerBase
    {

        private readonly UrlResolver _urlResolver;
        private readonly IContentRepository _contentRepository;

        public CarouselController(UrlResolver urlResolver, IContentRepository contentRepository)
        {
            _urlResolver = urlResolver;
            _contentRepository = contentRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var content = _contentRepository.Get<IContent>(new ContentReference(id));
            if (content is CarouselBlock carouselBlock)
            {
                if (carouselBlock.Slides == null)
                {

                    return Ok(new
                    {
                        carouselBlock.PreviousText,
                        carouselBlock.NextText,
                        carouselBlock.ShowTextLabels,
                        Slides = new List<string>()
                    });
                }
                var carousel = new
                {
                    carouselBlock.PreviousText,
                    carouselBlock.NextText,
                    carouselBlock.ShowTextLabels,
                    Slides = carouselBlock.Slides.Items
                                            .Select(slide => _contentRepository.Get<IContent>(slide.ContentLink) as SlideBlock)
                                            .Where(slide => slide != null)
                                            .Select(slide => new
                                            {
                                                slide.Title,
                                                slide.SubTitle,
                                                Image = slide.Image.FullUrl(Request, _urlResolver),
                                                Link = slide.Link.FullUrl(Request, _urlResolver),
                                            })
                                            .ToList()
                };
                return Ok(carousel);
            }


            return NotFound();
        }

    }
}
