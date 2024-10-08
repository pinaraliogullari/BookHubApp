﻿using MediatR;

namespace BookHubAPI.Application.Features.Commands.AppUser.CreateUser;

public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
{
    public string Fullname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }
}
