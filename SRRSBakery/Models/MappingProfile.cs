using AutoMapper;

namespace SRRSBakery.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Item, ItemMini>();

        }
    }
}


