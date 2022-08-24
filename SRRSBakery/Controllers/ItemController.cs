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
        private readonly IMapper mapper;                                   //Used to Map Object
        private readonly IConfiguration configuration;                    //Used to Connect API
        string baseAddress;                                              //stores the common address for Api
        private readonly IHttpContextAccessor httpContextAccessor;      //Used To Get HTTP Data(User Imformation)
        public ItemController(IitemRepository itemRepository, ICategoryRepository categoryRepository,IMapper mapper, IConfiguration configuration,IHttpContextAccessor httpContextAccessor)
        {
            this.itemRepository = itemRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
            this.httpContextAccessor=httpContextAccessor;
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

        public ViewResult Details(int id)    //used to Display the Detail of Particular Item
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
        public ViewResult Listmini()    //AutoMapper
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
        
        [HttpGet]
        public IActionResult ListAPI()   //List Of All Items Using API Data
        {
            var item = APIClass.GetAPIData(baseAddress + "GetAllItem");
            ItemListViewModel itemListViewModel = new ItemListViewModel();
            itemListViewModel.Items = item.Result;
            itemListViewModel.CurrentCategory = "All Items Using API";
            return View(itemListViewModel);
        }
    }

    }
