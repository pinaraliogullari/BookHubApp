using AutoMapper;
using BookHubAPI.Application.Exceptions;
using BookHubAPI.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHubAPI.Application.Features.Commands.AppUser.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
        Domain.Entities.Identity.AppUser appUser = _mapper.Map<Domain.Entities.Identity.AppUser>(request);
        IdentityResult result = await _userManager.CreateAsync(appUser, request.Password);

        CreateUserCommandResponse response = new() { Succeeded = result.Succeeded };
        if (result.Succeeded)
            response.Message = "User has been created successfully.";
        else
            foreach (var error in result.Errors)
            {
                response.Message += $"{error.Code}-{error.Description}<br>";
            }

        return response;

        //or;
        //throw new UserCreateFailedException();

    }
}
