using Builderz.Models.Blocks;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;

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
            //var pageId = new ContentReference(id);
            //var page = _pageSearchService.GetPageById<StandardPage>(pageId);
            //if (page == null)
            //{
            //    return NotFound();
            //}

            var content = _contentRepository.Get<IContent>(new ContentReference(id));
            if (content is CarouselBlock carouselBlock)
            {
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
                                                Image = _urlResolver.GetUrl(_contentRepository.Get<IContent>(slide.Image) as ImageData),
                                                Link = _urlResolver.GetUrl(slide.Link),

                                            })
                                            .ToList()
                };
                return Ok(carousel);
            }


            return NotFound();
        }

    }
}
