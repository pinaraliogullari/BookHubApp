using MediatR;

namespace BookHubAPI.Application.Features.Queires.AuthorImageFile.GetAuthorImages;

public class GetAuthorImagesQueryRequest : IRequest<List<GetAuthorImagesQueryResponse>>
{
    public string Id { get; set; }
}
