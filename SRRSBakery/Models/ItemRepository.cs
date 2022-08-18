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
    }
}
