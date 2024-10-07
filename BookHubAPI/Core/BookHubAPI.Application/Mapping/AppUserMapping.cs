using AutoMapper;
using BookHubAPI.Application.Features.Commands.AppUser.CreateUser;
using BookHubAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHubAPI.Application.Mapping;

public class AppUserMapping:Profile
{
    public AppUserMapping()
    {
        CreateMap<CreateUserCommandRequest, AppUser>().ReverseMap();
    }
}
