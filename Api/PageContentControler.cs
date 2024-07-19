using Builderz.Models.Pages;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Encodings.Web;
using System.Web;

namespace Builderz.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageContentController : ControllerBase
    {
        private readonly IContentRepository _contentRepository;
        private readonly UrlResolver _urlResolver;

        public PageContentController(UrlResolver urlResolver, IContentRepository contentRepository)
        {            
            _contentRepository = contentRepository;
            _urlResolver = urlResolver;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var content = _contentRepository.Get<IContent>(new ContentReference(id));
            if(content is SitePageData sitePageData)
            {                   
                var contents = sitePageData.MainContentArea.Items
                    .Select(c=> _contentRepository.Get<IContent>(c.ContentLink))
                    .Where(c=> c!= null)
                    .Select(c=> new
                {
                    Id = c.ContentLink.ID,
                    Type = c.GetOriginalType().Name,
                }).ToList();

                return Ok(contents);
            }

            return Ok(0);
        }
        [HttpGet("PageByPath/{path}")]
        public IActionResult GetByPath(string path) {            
            if (string.IsNullOrEmpty(path))
            {
                return BadRequest("Path is required.");
            }
            path = HttpUtility.UrlDecode(path);

            var contentReference = _urlResolver.Route(new UrlBuilder(path));
            if (contentReference == null || contentReference.ContentLink == ContentReference.EmptyReference)
            {
                return NotFound("Page not found.");
            }

            var page = _contentRepository.Get<PageData>(contentReference.ContentLink);
            if (page == null)
            {
                return NotFound("Page not found.");
            }

            return Ok(new
            {
                Id = page.ContentLink.ID,
                Name = page.Name,
                Type = page.GetOriginalType().Name,
                Path = path
            });
        }    
    }
}
