using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record UpdateMemberCommand(Guid id, string memberName) : IRequest<Guid>;
}
