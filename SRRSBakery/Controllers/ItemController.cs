using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemRepository _itemRepository;
        public ItemController(IitemRepository itemRepository)
        {
            _itemRepository = (ItemRepository)itemRepository;


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
