using MediatR;

namespace BookHubAPI.Application.Features.Commands.AuthorImageFile.RemoveAuthorImage;

public class RemoveAuthorImageCommandRequest : IRequest<RemoveAuthorImageCommandResponse>
{
    public string Id { get; set; }
    public string? ImageId { get; set; }
}
