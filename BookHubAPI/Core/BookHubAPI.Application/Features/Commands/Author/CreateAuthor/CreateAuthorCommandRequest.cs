using MediatR;

namespace BookHubAPI.Application.Features.Commands.Author.CreateAuthor;

public class CreateAuthorCommandRequest : IRequest<CreateAuthorCommandResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
