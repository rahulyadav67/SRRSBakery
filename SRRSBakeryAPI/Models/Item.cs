using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SRRSBakeryAPI.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlLarge { get; set; }
        public bool BestSeller { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        [BindNever]
        [ValidateNever]
        public Category Category { get; set; }
    }
}
