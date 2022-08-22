namespace SRRSBakery.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Item Item { get; set; }
        public Order Order { get; set; }
    }
}
