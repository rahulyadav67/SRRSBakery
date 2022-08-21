using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult ListCategory()
        {
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            var categories = categoryRepository.AllCategories;
            categoryListViewModel.category = categories;
            return View(categoryListViewModel);


        }
    }
}
