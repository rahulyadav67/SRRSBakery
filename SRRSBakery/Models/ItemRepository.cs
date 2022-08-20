using Microsoft.EntityFrameworkCore;

namespace SRRSBakery.Models
{
    public class ItemRepository : IitemRepository


    {
        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Item>GetAll=> appDbContext.Items.Include(n=>n.Category);
        public IEnumerable<Item> GetCakes => appDbContext.Items.Where(u => u.CategoryId == 1);
        public IEnumerable<Item> GetBreads => appDbContext.Items.Where(u => u.CategoryId == 2);
        public IEnumerable<Item> GetPancakes => appDbContext.Items.Where(u => u.CategoryId == 3);
        public IEnumerable<Item> GetCookies => appDbContext.Items.Where(u => u.CategoryId == 4);
        public IEnumerable<Item> GetCupCake => appDbContext.Items.Where(u => u.CategoryId == 5);
        public IEnumerable<Item> GetPizza => appDbContext.Items.Where(u => u.CategoryId == 6);
        public IEnumerable<Item> GetDonuts => appDbContext.Items.Where(u => u.CategoryId == 7);
        public IEnumerable<Item> GetChips => appDbContext.Items.Where(u => u.CategoryId == 8);

        public IEnumerable<ImageExtra> ImageExtra => appDbContext.ImageExtras.Include(n=>n.item);

        public IEnumerable<Item> GetCategoryById(int id)
        {
            return appDbContext.Items.Where(n => n.CategoryId == id);
        }
    }
}
