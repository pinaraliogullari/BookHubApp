﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHubAPI.Application.Features.Commands.AppUser.CreateUser;

public class CreateUserCommandResponse
{
    public bool Succeeded { get; set; }
    public string Message { get; set; }
}
