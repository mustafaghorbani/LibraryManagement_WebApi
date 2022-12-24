using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record SetBookReturnedCommand(string isbn, int memberId) : IRequest;
}
