namespace SRRSBakery.Models
{
    public interface IitemRepository 
    {
        IEnumerable<Item> GetAll { get; }
        IEnumerable<Item> BestSeller { get; }
        IEnumerable<Item> GetCakes { get; }
        /*IEnumerable<Item> GetBreads { get; }
        IEnumerable<Item> GetPancakes { get; }
        IEnumerable<Item> GetCookies { get; }
        IEnumerable<Item> GetCupCake { get; }
        IEnumerable<Item> GetPizza { get; }
        IEnumerable<Item> GetChips { get; }
        IEnumerable<Item> GetDonuts { get; }*/
        IEnumerable<ImageExtra> ImageExtra { get; }
        public IEnumerable<Item> GetCategoryById(int id);
        Item GetItemById(int itemId);
        Item AddItem(Item item);
        Item UpdateItem(Item item);
        Item DeleteItem(Item item);
    }
}
