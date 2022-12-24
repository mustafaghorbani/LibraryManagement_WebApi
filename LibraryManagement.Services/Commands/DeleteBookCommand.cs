using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record DeleteBookCommand(Guid id) : IRequest<Guid>;
}
