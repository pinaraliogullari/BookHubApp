﻿using BookHubAPI.Application.Abstractions.Token;
using BookHubAPI.Application.DTOs;
using BookHubAPI.Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace BookHubAPI.Application.Features.Commands.AppUser.LoginUser;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
    private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
    private readonly SignInManager<Domain.Entities.Identity.AppUser> _signInManager;
    private readonly ITokenHandler _tokenHandler;

    public LoginUserCommandHandler(
        UserManager<Domain.Entities.Identity.AppUser> userManager,
        SignInManager<Domain.Entities.Identity.AppUser> signInManager,
        ITokenHandler tokenHandler)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenHandler = tokenHandler;
    }

    public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        Domain.Entities.Identity.AppUser user = await _userManager.FindByNameAsync(request.UsernameOrEmail);
        if (user == null)
            user = await _userManager.FindByEmailAsync(request.UsernameOrEmail);

        if (user == null)
            throw new NotFoundUserException();

        SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
        if (result.Succeeded)//Authentication success.
        {
            //Authorization process...
            Token token = _tokenHandler.CreateAccessToken(20);
            return new LoginUserCommandSuccessResponse()
            {
                Token = token,
            };
        }
        //return new LoginUserCommandErrorResponse()
        //{
        //    Message = "Username or password is incorrect"
        //};
        throw new AuthenticationErrorException();
    }
}
