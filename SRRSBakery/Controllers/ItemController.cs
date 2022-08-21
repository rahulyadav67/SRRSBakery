using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class ItemController : Controller
    {
        private readonly IitemRepository itemRepository;
        private readonly ICategoryRepository categoryRepository;
        public ItemController(IitemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            this.itemRepository = itemRepository;
            this.categoryRepository = categoryRepository;

        }

        
        
        public IActionResult List(int id)
        {
            IEnumerable<Item> items;

            if (id > 0)
            {
               items=itemRepository.GetCategoryById(id);
            }
            else
            {
                items = itemRepository.GetAll;
            }
            return View(items);
        }
        /*public IActionResult ListChips()
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

        }*/

        public IActionResult ListCakes()
        {
            /*ItemListViewModel itemListViewModel = new ItemListViewModel();
            var Item = _itemRepository.GetCakes;
            itemListViewModel.Items = Item;
            return View(itemListViewModel);*/
            IEnumerable<Item> items;
            items = itemRepository.GetCakes;
            return View(items);

        }
        public ViewResult Details(int id)
        {
            var item = itemRepository.GetAll.FirstOrDefault(item => item.ItemId == id);
            return View(item);

        }
        public ViewResult Create()
        {
            var categories = categoryRepository.AllCategories;
            List<SelectListItem> categoryItems = new List<SelectListItem>();
            foreach (var category in categories)
            {
                categoryItems.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }
            ViewBag.categoryItems = categoryItems;
            return View();

        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {
            itemRepository.AddItem(item);
            return RedirectToAction("List");
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var categories = categoryRepository.AllCategories;
            List<SelectListItem> categoryItems = new List<SelectListItem>();
            foreach (var category in categories)
            {
                categoryItems.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }
            ViewBag.categoryItems = categoryItems;
            var item = itemRepository.GetItemById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
            itemRepository.UpdateItem(item);
            return RedirectToAction("List");
        }

        [Authorize]
        public ViewResult Remove(int id)
        {
            var item = itemRepository.GetItemById(id);
            return View(item);
        }


        [HttpPost]
        public IActionResult DeleteItem(Item item)
        {
            itemRepository.DeleteItem(item);
            return RedirectToAction("List");
        }
    }

    }
