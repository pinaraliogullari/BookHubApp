using MediatR;

namespace BookHubAPI.Application.Features.Queires.Author.GetByIdAuthor;

public class GetByIdAuthorQueryRequest : IRequest<GetByIdAuthorQueryResponse>
{
    public string Id { get; set; }
}
