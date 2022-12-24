using LibraryManagement.Domain.Domain;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetMemberByIdQuery(Guid id) : IRequest<Member>;
}
