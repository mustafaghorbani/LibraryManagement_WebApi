using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record CreateBookCommand(string title, string isbn, string author, string desicription) : IRequest;
}
