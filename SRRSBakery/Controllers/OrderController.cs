using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;

namespace SRRSBakery.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        //GET: //CONTROLLER/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Your Order has been placed.";
            return View();
        }
        public IActionResult DiscountItem(Order order)
        {
            double price = (double)_shoppingCart.GetShoppingCartTotal();
            price -= price * 0.20;
            ViewBag.NetPrice = price;
            ViewBag.OrderIdd = _shoppingCart.ShoppingCartId;
            return View();
        }

    }
}
