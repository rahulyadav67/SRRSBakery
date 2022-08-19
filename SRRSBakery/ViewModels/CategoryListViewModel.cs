using SRRSBakery.Models;

namespace SRRSBakery.ViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> category { get; set; }
        public string CurrentCategory { get; set; }
    }
}


