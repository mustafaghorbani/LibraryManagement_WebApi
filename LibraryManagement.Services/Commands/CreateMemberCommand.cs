using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record CreateMemberCommand(string memberName) : IRequest;
}
