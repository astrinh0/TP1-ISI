using AutoMapper;
using RestfullAPI.Models;
using TP1.Domain.Models.DTO;

namespace RestfullAPI.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ReverseMap();
        }
    }
}
