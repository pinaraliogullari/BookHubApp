using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Commands.Author.CreateAuthor;

public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
{
    private readonly IAuthorWriteRepository _authorWriteRepository;

    public CreateAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository)
    {
        _authorWriteRepository = authorWriteRepository;
    }

    public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        await _authorWriteRepository.AddAsync(new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
        });
        await _authorWriteRepository.SaveChangesAsync();
        return new();
    }
}
