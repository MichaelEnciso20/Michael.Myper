using AutoMapper;
using Michael.Myper.Application.DTO;
using Michael.Myper.Domain.Entity;

namespace Michael.Myper.Trasversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Trabajadore, TrabajadoreDto>().ReverseMap();
        }
    }
}