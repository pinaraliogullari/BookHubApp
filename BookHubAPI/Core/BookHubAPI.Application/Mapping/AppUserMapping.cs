using AutoMapper;
using BookHubAPI.Application.Features.Commands.AppUser.CreateUser;
using BookHubAPI.Domain.Entities.Identity;

namespace BookHubAPI.Application.Mapping;

public class AppUserMapping : Profile
{
    public AppUserMapping()
    {
        CreateMap<CreateUserCommandRequest, AppUser>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid().ToString()));
    }
}
