using Microsoft.EntityFrameworkCore;

namespace SRRSBakeryAPI.Models
{
    public class ItemRepository:IItemRepository
    {
        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Item> GetAll => appDbContext.Items.Include(n => n.Category);
        public IEnumerable<Item> BestSeller => appDbContext.Items.Where(n => n.BestSeller);
        public IEnumerable<Item> GetCakes => appDbContext.Items.Where(u => ((u.CategoryId == 1) || (u.CategoryId == 2) || (u.CategoryId == 3) || (u.CategoryId == 4) || (u.CategoryId == 5)));


        public IEnumerable<ImageExtra> ImageExtra => appDbContext.ImageExtras.Include(n => n.item);



        public IEnumerable<Item> GetCategoryById(int id)
        {
            return appDbContext.Items.Where(n => n.CategoryId == id);
        }
        public Item GetItemById(int itemId)
        {
            return this.GetAll.FirstOrDefault(Item => Item.ItemId == itemId);
        }

        public IEnumerable<Item> GetCategory(int Id)
        {
            return appDbContext.Items.Where(c => c.CategoryId == Id);
        }

        public Item AddItem(Item item)
        {
            var items = this.appDbContext.Items.Add(item);
            this.appDbContext.SaveChanges();
            return items.Entity;

        }

        public Item UpdateItem(Item item)
        {
            var items = this.appDbContext.Items.Update(item);
            this.appDbContext.SaveChanges();
            return items.Entity;
        }

        public Item DeleteItem(int itemId)
        {
            var itemss=this.appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
            var items = this.appDbContext.Items.Remove(itemss);
            this.appDbContext.SaveChanges();
            return items.Entity;

        }
    }
}
