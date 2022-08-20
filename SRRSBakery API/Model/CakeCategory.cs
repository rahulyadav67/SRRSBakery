namespace SRRSBakery_API.Model
{
    public class CakeCategory
    {
        public int CakeCategoryId { get; set; }
        public string CakeCategoryName { get; set; }
        public string CakeDescription { get; set; }
        public List<Cake> Cakes { get; set; }
    }
}