using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Commands.Author.UpdateAuthor;

public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
{
    private readonly IAuthorReadRepository _authorReadRepository;
    private readonly IAuthorWriteRepository _authorWriteRepository;

    public UpdateAuthorCommandHandler(
        IAuthorReadRepository authorReadRepository,
        IAuthorWriteRepository authorWriteRepository)
    {
        _authorReadRepository = authorReadRepository;
        _authorWriteRepository = authorWriteRepository;
    }

    public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        BookHubAPI.Domain.Entities.Author author = await _authorReadRepository.GetByIdAsync(request.Id);
        author.FirstName = request.FirstName;
        author.LastName = request.LastName;
        await _authorWriteRepository.SaveChangesAsync();
        return new();
    }
}
