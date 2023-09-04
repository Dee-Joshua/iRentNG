using AutoMapper;
using IRentNG.Entities.Models;
using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.API
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<User, UserDto>();

        }
    }
}
