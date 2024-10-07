using BookHubAPI.Application.Features.Commands.AppUser.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHubAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

     
        public async Task<IActionResult> Create(CreateUserCommandRequest request)
        {
           CreateUserCommandResponse response= await _mediator.Send(request);
            return Ok(response);
        }
    }
}
