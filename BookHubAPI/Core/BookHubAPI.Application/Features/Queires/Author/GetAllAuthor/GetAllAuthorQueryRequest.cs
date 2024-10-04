using MediatR;

namespace BookHubAPI.Application.Features.Queires.Author.GetAllAuthor;

public class GetAllAuthorQueryRequest : IRequest<GetAllAuthorQueryResponse>
{
    //public Pagination Pagination { get; set; }
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
