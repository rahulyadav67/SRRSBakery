namespace SRRSBakery.Models
{
    public class ImageExtra    //Contains Extra Images For Cake
    {
        public int ImageExtraId { get; set; }
        public string ImageUrlSecondLarge { get; set; }
        public string ImageUrlThirdLarge { get; set; }
        public int ItemId { get; set; }
        public Item item { get; set; }
    }
}
