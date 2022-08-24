using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryRepository categoryRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public CategoryController(ICategoryRepository categoryRepository,IHttpContextAccessor httpContextAccessor)
        {
            this.categoryRepository = categoryRepository;
            this.httpContextAccessor = httpContextAccessor;
        }
        public IActionResult ListCategory()
        {
            var user = httpContextAccessor.HttpContext.User.Identity.Name;
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            var categories = categoryRepository.AllCategories;
            categoryListViewModel.category = categories;
            return View(categoryListViewModel);
        }
        public IActionResult ModifyCategory()
        { 
            var categories = categoryRepository.AllCategories;
            return View(categories);
        }
        [Authorize]
        public ViewResult CreateCategory()
        {
            return View();
        }
        [Authorize]
        public ViewResult EditCategory(int id)
        {
            var categories = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id);
            return View(categories);
        }
        [Authorize]
        public ViewResult RemoveCategory(int id)
        {
            var category = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryRepository.AddCategory(category);
            return RedirectToAction("ListCategory");
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
            return RedirectToAction("ListCategory");
        }
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            categoryRepository.DeleteCategory(category);
            return RedirectToAction("ListCategory");
        }
    }
}
