using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Products.Commands;
namespace HelpApp.Application.Mappings
{
    public class DTOToCommandMapingProfile : Profile
    {
        public DTOToCommandMapingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}
