using AutoMapper;
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
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;   //Used to Connect API
        string baseAddress;
        public ItemController(IitemRepository itemRepository, ICategoryRepository categoryRepository,IMapper mapper, IConfiguration configuration)
        {
            this.itemRepository = itemRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }

        
        public IActionResult List(int id=0)
        {
            IEnumerable<Item> items;

            if (id == 1)
            {
                items = itemRepository.GetCakes;
            }
            else if(id > 0)
            {
               items=itemRepository.GetCategoryById(id);
            }
            else
            {
                items = itemRepository.GetAll;
            }
            return View(items);
        }
        

        /*public IActionResult ListCakes()
        {
            IEnumerable<Item> items;
            items = itemRepository.GetCakes;
            return View(items);

        }*/
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
        public ViewResult Listmini()
        {
            var item = itemRepository.GetAll;
            var itemmini = mapper.Map<IEnumerable<ItemMini>>(item);
            return View(itemmini);
        }
        public IActionResult Search(string searchitem)
        {
            var items = itemRepository.GetAll.Where(s => s.Name.ToUpper().Contains(searchitem.ToUpper()));
            return View(items);

        }
        public ViewResult OutOfStock()
        {
            return View();
        }
        //List Of All Items Using API Data
        [HttpGet]
        public IActionResult ListAPI()
        {
            var item = APIClass.GetAPIData(baseAddress + "GetAllItem");
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            itemListViewModel.Items = item.Result;
            itemListViewModel.CurrentCategory = "All Items Using API";
            return View(itemListViewModel);
        }
    }

    }
