namespace SRRSBakery.Models
{
    public interface IitemRepository 
    {
        IEnumerable<Item> GetChips { get; }

        IEnumerable<Item> GetDonuts { get; }

        IEnumerable<Item> GetBread { get; }

        IEnumerable<Item> GetPanCakes { get; }

        IEnumerable<Item> GetCookies { get; }

        IEnumerable<Item> GetCupCakes { get; }

        IEnumerable<Item> GetPizzas { get; }


    }
}
