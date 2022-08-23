using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;

namespace SRRSBakery.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categoryItems = this.categoryRepository.AllCategories;
            return View(categoryItems);
        }
    }
}
