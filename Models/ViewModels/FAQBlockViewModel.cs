using Builderz.Models.Blocks;

namespace Builderz.Models.ViewModels
{
    public class FAQBlockViewModel
    {
        public FAQBlock CurrentBlock { get; set; }
        public IList<FAQItemBlock> Col1 { get; set; }
        public IList<FAQItemBlock> Col2 { get; set; }
    }
}
