namespace SRRSBakery_API.Model
{
    public interface IitemRepository 
    {
        IEnumerable<Item> GetAll { get; }
        IEnumerable<Item> GetCakes { get; }
        IEnumerable<Item> GetBreads { get; }
        IEnumerable<Item> GetPancakes { get; }
        IEnumerable<Item> GetCookies { get; }
        IEnumerable<Item> GetCupCake { get; }
        IEnumerable<Item> GetPizza { get; }
        IEnumerable<Item> GetChips { get; }
        IEnumerable<Item> GetDonuts { get; }
    }
}
