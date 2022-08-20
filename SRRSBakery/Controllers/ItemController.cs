using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemRepository _itemRepository;
        private readonly CategoryRepository _CategoryRepository;
        public ItemController(IitemRepository itemRepository, ICategoryRepository categoryRepository)
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
            var Chips = _itemRepository.GetChips;
            itemListViewModel.Items = Chips;
            return View(itemListViewModel);
        }
        public IActionResult ListDonuts()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var donuts = _itemRepository.GetDonuts;
            itemListViewModel.Items = donuts;
            return View(itemListViewModel);
        }
        public ViewResult Details(int id)
        {
            var item = _itemRepository.GetAll.FirstOrDefault(item => item.ItemId == id);
            return View(item);

        }
        public IActionResult ListCookies()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetCookies;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);

        }
        public IActionResult ListPizzas()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetPizza;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);

        }
        public IActionResult ListPanCakes()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetPancakes;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);

        }

        public IActionResult ListBread()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetBreads;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);

        }

        public IActionResult ListCakes()
        {
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetCakes;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);

        }
    }

    }
