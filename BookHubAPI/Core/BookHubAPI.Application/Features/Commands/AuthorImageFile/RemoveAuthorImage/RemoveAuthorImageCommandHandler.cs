using BookHubAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookHubAPI.Application.Features.Commands.AuthorImageFile.RemoveAuthorImage;

public class RemoveAuthorImageCommandHandler : IRequestHandler<RemoveAuthorImageCommandRequest, RemoveAuthorImageCommandResponse>
{
    private readonly IAuthorReadRepository _authorReadRepository;
    private readonly IAuthorWriteRepository _authorWriteRepository;

    public RemoveAuthorImageCommandHandler(
        IAuthorReadRepository authorReadRepository,
        IAuthorWriteRepository authorWriteRepository)
    {
        _authorReadRepository = authorReadRepository;
        _authorWriteRepository = authorWriteRepository;
    }

    public async Task<RemoveAuthorImageCommandResponse> Handle(RemoveAuthorImageCommandRequest request, CancellationToken cancellationToken)
    {
        Domain.Entities.Author? author = await _authorReadRepository.Table.Include(x => x.AuthorImageFiles).FirstOrDefaultAsync(x => x.Id == Guid.Parse(request.Id));

        Domain.Entities.AuthorImageFile? authorImageFile = author?.AuthorImageFiles.FirstOrDefault(x => x.Id == Guid.Parse(request.ImageId));

        if (authorImageFile != null)
            author?.AuthorImageFiles.Remove(authorImageFile);
        await _authorWriteRepository.SaveChangesAsync();

        return new();
    }
}
