namespace SRRSBakery.Models
{
    public class ItemRepository : IitemRepository


    {
        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Item> GetChips => appDbContext.Items.Where(u=>u.CategoryId==8);

        public IEnumerable<Item> GetDonuts => appDbContext.Items.Where(u => u.CategoryId == 7);

        public IEnumerable<Item> GetBread => appDbContext.Items.Where(u => u.CategoryId == 2);

        public IEnumerable<Item> GetPanCakes => appDbContext.Items.Where(u => u.CategoryId == 3);

        public IEnumerable<Item> GetCookies => appDbContext.Items.Where(u => u.CategoryId == 4);

        public IEnumerable<Item> GetCupCakes => appDbContext.Items.Where(u => u.CategoryId == 5);

        public IEnumerable<Item> GetPizzas => appDbContext.Items.Where(u => u.CategoryId == 6);
    }
}
