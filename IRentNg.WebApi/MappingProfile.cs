using AutoMapper;
using IRentNG.Entities.Models;
using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, ContactDto>();
            CreateMap<Property, PropertyDto>()
                .ForMember(p => p.Structure, opt => opt.MapFrom(p => p.Structure.ToString()))
                .ForMember(p => p.Privacy, opt => opt.MapFrom(p => p.Privacy.ToString()))
                .ForMember(p => p.Duration, opt => opt.MapFrom(p => p.Duration.ToString()));
            CreateMap<PropertyForCreationDto, Property>();
            CreateMap<PropertyForUpdateDto, Property>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(u => u.Email))
                .ForMember(u => u.FullName, opt => opt.MapFrom(u => string.Join(' ', u.FirstName, u.LastName)));
            
           
        }
    }
}
