using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetBookByIdQuery(Guid id) : IRequest<BookDto>;
}
