namespace SRRSBakery.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        

        public IEnumerable<Category> GetCategories => (IEnumerable<Category>)appDbContext.Categories;
    }
}




