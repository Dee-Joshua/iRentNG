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
            CreateMap<Property, PropertyDto>();

            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(u => u.Email));
        }
    }
}
