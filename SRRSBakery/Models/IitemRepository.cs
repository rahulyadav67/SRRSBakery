namespace SRRSBakery.Models
{
    public interface IitemRepository 
    {
        IEnumerable<Item> GetAll { get; }
        IEnumerable<Item> BestSeller { get; }
        IEnumerable<Item> GetCakes { get; }
        IEnumerable<ImageExtra> ImageExtra { get; }
        public IEnumerable<Item> GetCategoryById(int id);
        Item GetItemById(int itemId);
        Item AddItem(Item item);
        Item UpdateItem(Item item);
        Item DeleteItem(Item item);
    }
}
