using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;

namespace SRRSBakery.Controllers
{
    [Authorize]
    public class ShoppingCartController: Controller
    {
        private readonly IitemRepository itemRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IitemRepository itemRepository, ShoppingCart shoppingCart)
        {
            this.itemRepository = itemRepository;
            this.shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }




        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = itemRepository.GetAll.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                shoppingCart.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = itemRepository.GetAll.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                shoppingCart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveItemShoppingCart(int itemId)
        {

            var selectedItem = itemRepository.GetAll.FirstOrDefault(p => p.ItemId == itemId);
            if (selectedItem != null)
            {
                shoppingCart.RemoveItemFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }


        public RedirectToActionResult ClearCart()
        {
            shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }




    }
}
