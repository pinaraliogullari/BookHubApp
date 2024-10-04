using BookHubAPI.Application.Features.Commands.CreateAuthor;
using MediatR;

namespace BookHubAPI.Application.Features.Commands.CreateProduct;

public class CreateAuthorCommandRequest:IRequest<CreateAuthorCommandResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
