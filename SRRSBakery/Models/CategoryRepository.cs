using Microsoft.EntityFrameworkCore;

namespace SRRSBakery.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<Category> AllCategories => appDbContext.Categories.Include(n=>n.Items);
        public Category AddCategory(Category category)
        {
            var categories = this.appDbContext.Categories.Add(category);
            this.appDbContext.SaveChanges();
            return categories.Entity;
        }

        public Category DeleteCategory(Category category)
        {
            var categories = this.appDbContext.Categories.Remove(category);
            this.appDbContext.SaveChanges();
            return categories.Entity;

        }

        public Category UpdateCategory(Category category)
        {
            var categories = this.appDbContext.Categories.Update(category);
            this.appDbContext.SaveChanges();
            return categories.Entity;
        }


    }
}




