using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Commands.Author.RemoveAuthor;

public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommandRequest, RemoveAuthorCommandResponse>
{
    private readonly IAuthorWriteRepository _authorWriteRepository;

    public RemoveAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository)
    {
        _authorWriteRepository = authorWriteRepository;
    }

    public async Task<RemoveAuthorCommandResponse> Handle(RemoveAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        await _authorWriteRepository.RemoveAsync(request.Id);
        await _authorWriteRepository.SaveChangesAsync();
        return new();
    }
}
