namespace SRRSBakery.Models
{
    public class Item
    {
        public int ItemId { get; set; } 
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlLarge { get; set; }
        public bool BestSeller { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ImageExtra ImageExtra { get; set; }
    }
}
