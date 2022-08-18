namespace SRRSBakery.Models
{
    public interface IitemRepository 
    {
        IEnumerable<Item> GetChips { get; }

        IEnumerable<Item> GetDonuts { get; }
    }
}
