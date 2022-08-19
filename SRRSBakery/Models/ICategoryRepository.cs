namespace SRRSBakery.Models
{
    public interface ICategoryRepository
    {

        IEnumerable<Category> GetCategories { get; }
    }
}



