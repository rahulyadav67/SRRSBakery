using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemRepository _itemRepository;
        private readonly CategoryRepository _CategoryRepository;
        public ItemController(IitemRepository itemRepository,ICategoryRepository categoryRepository)
        {
            _itemRepository = (ItemRepository)itemRepository;
            _CategoryRepository = (CategoryRepository)categoryRepository;

        }
        public IActionResult Index()
        {
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            var categories = _CategoryRepository.GetCategories;
            categoryListViewModel.category = categories;
            return View(categoryListViewModel);

        }
        public IActionResult ListChips()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var donuts = _itemRepository.GetChips;
            itemListViewModel.Items = donuts;
            return View(itemListViewModel);
        }
        public IActionResult ListDonuts()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var donuts = _itemRepository.GetDonuts;
            itemListViewModel.Items = donuts;
            return View(itemListViewModel);
        }
    }
}
