using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IitemRepository _ItemRepository  ;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IitemRepository ItemRepository, ShoppingCart shoppingCart)
        {
            _ItemRepository = ItemRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedPie = _ItemRepository.GetAll.FirstOrDefault(p => p.ItemId == pieId);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            // var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);
            _shoppingCart.ClearCart();

            /*  if (selectedPie != null)
              {
                  _shoppingCart.RemoveFromCart(selectedPie);
              }
            */
            return RedirectToAction("Index");
        }
    }
}

