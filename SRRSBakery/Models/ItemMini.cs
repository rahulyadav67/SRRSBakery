namespace SRRSBakery.Models
{
    public class ItemMini
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }

    }
}
