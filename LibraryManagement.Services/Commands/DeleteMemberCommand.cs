using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record DeleteMemberCommand(Guid id) : IRequest<Guid>;
}
