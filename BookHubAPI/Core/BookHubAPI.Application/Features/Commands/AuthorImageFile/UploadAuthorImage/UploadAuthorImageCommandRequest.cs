using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookHubAPI.Application.Features.Commands.AuthorImageFile.UploadAuthorImage;

public class UploadAuthorImageCommandRequest : IRequest<UploadAuthorImageCommandResponse>
{
    public string Id { get; set; }
    public IFormFileCollection? Files { get; set; }
}
