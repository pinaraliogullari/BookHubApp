using MediatR;

namespace BookHubAPI.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest : IRequest<UpdateAuthorCommandResponse>
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
