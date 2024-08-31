using AutoMapper;
using Product.Core.Entities;
using Product.Core.Entities.DTO;

namespace Product.API.Mapping_Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDTO, Products>();
            CreateMap<OrderDTO, Orders>();
        }
    }
}
