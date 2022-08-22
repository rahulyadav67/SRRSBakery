namespace SRRSBakeryAPI.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll { get; }
        IEnumerable<Item> BestSeller { get; }
        IEnumerable<Item> GetCakes { get; }
        IEnumerable<ImageExtra> ImageExtra { get; }
        IEnumerable<Item> GetCategoryById(int id);
        Item GetItemById(int itemId);
        Item AddItem(Item item);
        Item UpdateItem(Item item);
        Item DeleteItem(int itemId);
    }
}
