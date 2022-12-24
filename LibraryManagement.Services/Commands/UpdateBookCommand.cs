using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record UpdateBookCommand(int Guid, string title, string isbn, bool isAvailable) : IRequest<Guid>;
}
