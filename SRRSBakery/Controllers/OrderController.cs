/*using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;

namespace SRRSBakery.Controllers
{
        public class OrderController : Controller
        {
            private readonly IorderRepository _orderRepository;
            private readonly ShoppingCart _shoppingCart;
            public OrderController(IorderRepository orderRepository, ShoppingCart shoppingCart)
            {
                _orderRepository = orderRepository;
                _shoppingCart = shoppingCart;
            }

            public IActionResult CheckOut()
            {
                return View();
            }
            // the methods of posting client data 
            [HttpPost]
            public IActionResult CheckOut(Order order)
            {
                var items = _shoppingCart.GetShoppingCartItems();
                _shoppingCart.ShoppingCartItems = items;
                if (_shoppingCart.ShoppingCartItems.Count == 0)
                {
                    ModelState.AddModelError("", "Your Cart is empty! Add some pies first");

                }
                if (ModelState.IsValid)
                {
                    _orderRepository.CreateOrder(order);
                    _shoppingCart.ClearCart();

                }
                return RedirectToAction("CheckOutComplete");

            }
            public IActionResult CheckOutComplete()
            {
                ViewBag.CheckOutCompleteMessage = "Thanks for order!!!!!!!";
                return View();
            }
        }
    
}
*/