namespace SRRSBakeryAPI.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        Category AddCategory(Category category);
        Category UpdateCategory(Category category);
        Category DeleteCategory(int categoryId);
    }
}
