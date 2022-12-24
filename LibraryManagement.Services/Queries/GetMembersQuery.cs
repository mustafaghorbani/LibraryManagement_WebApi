using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetMembersQuery : IRequest<List<MemberDto>>;
}
