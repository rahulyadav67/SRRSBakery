namespace SRRSBakery.Models
{
    public class OrderRepository:IorderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetail = new List<OrderDetails>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetails
                {
                    Amount = shoppingCartItem.Amount,
                    ItemId = shoppingCartItem.item.ItemId,
                    Price = shoppingCartItem.item.Price
                };

                order.OrderDetail.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}

