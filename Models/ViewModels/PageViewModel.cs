using Builderz.Models.Pages;

namespace Builderz.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }
        public PageViewModel(T currentPage) => CurrentPage = currentPage;

    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage) where T : SitePageData => new(currentPage);

    }
}
