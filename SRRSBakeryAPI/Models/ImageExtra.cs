namespace SRRSBakeryAPI.Models
{
    public class ImageExtra
    {
        public int ImageExtraId { get; set; }
        public string ImageUrlSecondLarge { get; set; }
        public string ImageUrlThirdLarge { get; set; }
        public int ItemId { get; set; }
        public Item item { get; set; }
    }
}
