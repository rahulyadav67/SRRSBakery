namespace SRRSBakery_API.Model
{
    public class Cake
    {
        public int CakeId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlLargee { get; set; }
        public string ImageUrlLargeee { get; set; }
        public bool Bestseller { get; set; }
        public bool InStock { get; set; }
        public int CakeCategoryId { get; set; }
        public CakeCategory CakeCategory { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}