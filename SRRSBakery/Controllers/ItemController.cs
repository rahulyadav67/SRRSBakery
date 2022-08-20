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
        public IActionResult ListBread()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Bread = _itemRepository.GetBread;
            itemListViewModel.Items = Bread;
            return View(itemListViewModel);
        }
        public IActionResult ListPanCakes()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var PanCakes = _itemRepository.GetPanCakes;
            itemListViewModel.Items = PanCakes;
            return View(itemListViewModel);
        }
        public IActionResult ListCookies()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Cookies = _itemRepository.GetCookies;
            itemListViewModel.Items = Cookies;
            return View(itemListViewModel);
        }
        public IActionResult ListCupCakes()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var CupCakes = _itemRepository.GetCupCakes;
            itemListViewModel.Items = CupCakes;
            return View(itemListViewModel);
        }
        public IActionResult ListPizzas()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Pizzas = _itemRepository.GetPizzas;
            itemListViewModel.Items = Pizzas;
            return View(itemListViewModel);
        }
    }
}
